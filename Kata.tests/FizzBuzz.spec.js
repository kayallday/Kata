describe("The Fizz Buzz Player", function () {
    var _game;
    var _logger = {
        log: function () {

        }
    }

    beforeEach(function () {
        _game = new FizzBuzzPlayer(_logger);
    });

    expectResult("1", 1);
    expectResult("2", 2);
    expectResult("fizz", 3);
    expectResult("buzz", 5);
    expectResult("fizz", 6);
    expectResult("buzz", 10);
    expectResult("fizzbuzz", 15);
    expectResult("fizzbuzz", 30);

    expectLog("given 1 returns 1.", 1);
    expectLog("given 2 returns 2.", 2);
    expectLog("given 3 returns fizz.", 3);
    expectLog("given 15 returns fizzbuzz.", 15);


    function expectLog(message, input) {
        it("logs a play of " + input, function () {
            spyOn(_logger, "log");
            _game.play(input)
            expect(_logger.log).toHaveBeenCalledWith(message);
        })
    }

    function expectResult(expected, input) {
        describe("given " + input, function () {
            it("returns " + expected, function () {
                expect(_game.play(input)).toEqual(expected);
            })
        });
    }
})