const chai = require('chai');
const expect = chai.expect;
const math = require('../mathUtils');

describe('Math Utilities', function () {
  describe('add()', function () {
    it('should return the sum of two numbers', function () {
      expect(math.add(2, 3)).to.equal(5);
    });
  });

  describe('subtract()', function () {
    it('should return the difference of two numbers', function () {
      expect(math.subtract(5, 2)).to.equal(3);
    });
  });

  describe('isEven()', function () {
    it('should return true for even numbers', function () {
      expect(math.isEven(4)).to.be.true;
    });

    it('should return false for odd numbers', function () {
      expect(math.isEven(5)).to.be.false;
    });
  });
});
