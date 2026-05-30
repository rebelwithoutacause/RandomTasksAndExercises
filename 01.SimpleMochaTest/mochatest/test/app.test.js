const chai = require('chai');
const expect = chai.expect;

describe('Basic Test', function () {
  it('should return true', function () {
    expect(true).to.equal(true);
  });

  it('should add numbers correctly', function () {
    const sum = 2 + 3;
    expect(sum).to.equal(5);
  });
});
