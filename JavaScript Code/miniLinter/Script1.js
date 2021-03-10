// JavaScript source code
//creation of string variable story
let story = 'Last weekend, I took literally the most beautiful bike ride of my life. The route is called "The 9W to Nyack" and it actually stretches all the way from Riverside Park in Manhattan to South Nyack, New Jersey. It\'s really an adventure from beginning to end! It is a 48 mile loop and it basically took me an entire day. I stopped at Riverbank State Park to take some extremely artsy photos. It was a short stop, though, because I had a really long way left to go. After a quick photo op at the very popular Little Red Lighthouse, I began my trek across the George Washington Bridge into New Jersey.  The GW is actually very long - 4,760 feet! I was already very tired by the time I got to the other side.  An hour later, I reached Greenbrook Nature Sanctuary, an extremely beautiful park along the coast of the Hudson.  Something that was very surprising to me was that near the end of the route you actually cross back into New York! At this point, you are very close to the end.';
//creation of array storyWords with each word from story
const storyWords = story.split(' ');
//log to console total number of words
console.log(storyWords.length);
//creation of array unnecessaryWords
let unnecessaryWords = ['extremely', 'literally', 'actually'];
//creation of betterWords array removing extremely
let betterWords = storyWords.filter(words => {
    return words != 'extremely';
})
//update of betterWords array removing literally
betterWords = betterWords.filter(words => {
    return words != 'literally';
})
//update of betterwords array removing actually
betterWords = betterWords.filter(words => {
    return words != 'actually';
})
//print betterwords length to the console
console.log(betterWords.length)
//print betterwords array to console
console.log(betterWords);
//creation of array overusedWords
let overusedWords = ['really', 'very', 'basically'];
//creation of variable numTimes
numTimes = 0;
//for loop to determine how many times overusedWords are used
for (i = 0; i < betterWords.length; i++) {
    for (j = 0; j < overusedWords.length; j++) {
        if (betterWords[i] === overusedWords[j])
            numTimes++;
    }
}
//printing the numTimes variable to console
console.log(numTimes);
//creation of variable totalSentences set to 0
let totalSentences = 0;
//iteration to determine the number of sentences in betterWords array
betterWords.forEach(word => {
    if (word[word.length - 1] === '.' || word[word.length - 1] === '!') {
        totalSentences++;
    }
})
//setting totallength to betterwords length
let totallength = betterWords.length;
//logging stats to console with console.log command
console.log(betterWords.length);
console.log(totalSentences);
console.log(numTimes);
//creating function to print stats
const logInfo = (param1, param2, param3) => {
    console.log('Word count: ' + param1);
    console.log('Total num of sentences: ' + param2);
    console.log('Total overused words: ' + param3);
}
//joining the array to create a paragraph
console.log(betterWords.join(' '));
//calling function to display stats
logInfo(totallength, totalSentences, numTimes);