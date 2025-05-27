const chai = require('chai');
const expect = chai.expect;
const stringUtils = require('../stringUtils');

describe('String Utilities', function () {

  describe('capitalize()', function () {
    it('should capitalize the first letter of a lowercase word', function () {
      expect(stringUtils.capitalize('hello')).to.equal('Hello');
    });

    it('should leave the first letter capitalized if already capitalized', function () {
      expect(stringUtils.capitalize('World')).to.equal('World');
    });

    it('should return empty string for non-string input', function () {
      expect(stringUtils.capitalize(123)).to.equal('');
      expect(stringUtils.capitalize(null)).to.equal('');
      expect(stringUtils.capitalize(undefined)).to.equal('');
    });
  });

  describe('reverse()', function () {
    it('should reverse a normal string', function () {
      expect(stringUtils.reverse('hello')).to.equal('olleh');
    });

    it('should reverse a palindrome correctly', function () {
      expect(stringUtils.reverse('madam')).to.equal('madam');
    });

    it('should return empty string for non-string input', function () {
      expect(stringUtils.reverse(456)).to.equal('');
      expect(stringUtils.reverse(null)).to.equal('');
    });
  });

  describe('isPalindrome()', function () {
    it('should return true for a palindrome string', function () {
      expect(stringUtils.isPalindrome('madam')).to.be.true;
    });

    it('should return true for a palindrome ignoring case and non-alphanumeric chars', function () {
      expect(stringUtils.isPalindrome('A man, a plan, a canal, Panama')).to.be.true;
    });

    it('should return false for a non-palindrome string', function () {
      expect(stringUtils.isPalindrome('hello')).to.be.false;
    });

    it('should return false for non-string input', function () {
      expect(stringUtils.isPalindrome(789)).to.be.false;
      expect(stringUtils.isPalindrome(null)).to.be.false;
    });
  });

});
