const robot = {
	model: 'SAL-1000',
	mobile: true,
	sentient: false,
	armor: 'Steel-plated',
	energyLevel: 75
};

// What is missing in the following method call?
const robotKeys = Object.keys(robot);

console.log(robotKeys);//logs to console [ 'model', 'mobile', 'sentient', 'armor', 'energyLevel' ]

// Declare robotEntries below this line:
const robotEntries = Object.entries(robot);

console.log(robotEntries); // logs to console [ [ 'model', 'SAL-1000' ],['mobile', true],['sentient', false],['armor', 'Steel-plated'],	['energyLevel', 75] ]

// Declare newRobot below this line: object.assign({new properties}, all properties within object robot)
const newRobot = Object.assign({ laserBlaster: true, voiceRecognition: true }, robot);

console.log(newRobot);
//logs to console { laserBlaster: true, voiceRecognition: true, model: 'SAL-1000', mobile: true, sentient: false, armor: 'Steel-plated', energyLevel: 75 }