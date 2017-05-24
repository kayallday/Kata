function FizzBuzzPlayer(logger) {
    return {
        play: function (input) {
            var result = "";
            if (input % 3 == 0) 
                result += "fizz";
            if (input % 5 == 0)
                result += "buzz";
            if (!result)
                result = input.toString();
            logger.log("given " + input + " returns " + result + ".");
            return result;
        }
    }
}