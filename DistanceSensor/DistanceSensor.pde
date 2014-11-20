

const int distancePin = 1;

void setup()
{
	pinMode(distancePin, INPUT);
	Serial.begin(9600);
}

void loop()
{
	if(Serial.read()>0)
	{
		//My calibrated distance sensor - SHARP 2Y0A02 F 9Y 
		//To calibrate your own device get a ruler and make the measures...
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
