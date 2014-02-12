

const int distancePin = 1;
//const float A = 0.0082712905;
//const float B = 939.57652;
//const float C = -3.3978697;
//const float D = 17.339222;

void setup()
{
	pinMode(distancePin, INPUT);
	Serial.begin(9600);
	/* add setup code here */

}

void loop()
{
	if(Serial.read()>0)
	{
	//My calibrated distance sensor - SHARP 2Y0A02 F 9Y 
	// out[] holds the values wanted in cm
	//float out[] = { 150,145, 140,135, 130, 125, 120, 115, 110, 105, 100, 95, 90, 85, 80, 75, 70, 65, 60, 55, 50, 45, 40, 35, 30,25, 20};
	// in[] holds the measured analogRead() values for defined distances
	//float in[]  = { 82, 83, 88, 91, 95, 99, 103, 109, 113 , 119, 124 ,133, 140 , 149, 158,169, 178, 193, 209, 232, 257, 289, 331, 383, 440, 460 };

	float measures1[10];
	float measures2[10];
	for(int j = 0; j < 10; j++)
	{
		int counter = 0;
		while(counter < 10)
		{	
			delay(20);
			float val = analogRead(A1); 
			float cm = 9462/(val - 16.92);//FmultiMap(val, in, out, 27);
			measures1[counter]=cm;
			counter ++;
		}
		
		measures2[j] = GetAverage(measures1, 10);
	}

	float precisionAvg = GetAverage(measures2, 10);
	
	Serial.println(precisionAvg);
}

}



	/*if (Serial.read() > 0 )
	{
		Serial.flush();
	//Define vars
double a = 2.6072724878814660E+02;
	double b = -4.1323910205865479E+02;
	double c = 2.7441697926457056E+02;
	double d = -6.1307487656226428E+01;
	double f = -7.7823651718988458E+00;
	double g = 3.4672327551107287E+00;

	//raw data capture
	float range_values[100];

	//after average values
	float avg_value[100];

	float volt[100];
	float avg_volt[100];

	int counter = 0;
	int timeout = 0;
	double temp = 0.0;
	//Read 20 values
	while(counter < 100)
	{
		delay(20);
		float sensorValue = analogRead(distancePin);
		
		
		float range_value =   sensorValue;
		if ( range_value >=  80 && range_value < 490     ) 
		{
			range_value = range_value*0.0048828125;
			temp = g;
	temp = temp * range_value + f;
	temp = temp * range_value + d;
	temp = temp * range_value + c;
	temp = temp * range_value + b;
	temp = temp * range_value + a;
			float range = temp;
			range_values[counter] = range;
			volt[counter] = range_value;
			counter++;
		}
	}


	//Calculate average
	float mean = 0;
	float volt_mean = 0;
	for(int i = 0; i < 100; i++)
	{
		mean += range_values[i];
		volt_mean += volt[i];
	}
	mean = mean / 100;
	volt_mean = volt_mean / 100;
	

	//Remove values that are great or less than 15%
	float topMax = volt_mean * 1.15;
	float topMin = volt_mean * 0.85;

	int counteravg = 0;
	for(int i = 0; i < 100; i++)
	{
		
		if (volt[i] < topMax && volt[i] > topMin)
		{
			avg_value[counteravg] = range_values[i];
			avg_volt[counteravg] = volt[i];
			counteravg++;
		}
	}

	//Get average again
	mean = 0;
	volt_mean = 0;
	for(int i = 0; i < counteravg; i++)
	{
			mean += avg_value[i];
			volt_mean += avg_volt[i];
	}

		mean = mean / counteravg;
		volt_mean = volt_mean / counteravg;
		Serial.println(mean);
	}
	Serial.flush();*/

float GetAverage(float * _values, uint8_t size)
{
	float avg = 0;
	for(int i = 0; i< size; i++)
	{
		avg += _values[i];
	}
	avg = avg / size;

	float setMax = avg * 1.15;
	float setMin = avg * 0.85;
	float precisionAvg;
	int counter = 0;
	for(int i = 0; i < size; i++)
	{
		if((setMin < _values[i]) && (_values[i] < setMax))
		{
			precisionAvg += _values[i];
			counter++;
		}
	}
	return precisionAvg / counter;
}

float FmultiMap(float val, float * _in, float * _out, uint8_t size)
{
  // take care the value is within range
  // val = constrain(val, _in[0], _in[size-1]);
  if (val <= _in[0]) return _out[0];
  if (val >= _in[size-1]) return _out[size-1];

  // search right interval
  uint8_t pos = 1;  // _in[0] allready tested
  while(val > _in[pos]) pos++;

  // this will handle all exact "points" in the _in array
  if (val == _in[pos]) return _out[pos];

  // interpolate in the right segment for the rest
  return (val - _in[pos-1]) * (_out[pos] - _out[pos-1]) / (_in[pos] - _in[pos-1]) + _out[pos-1];
}