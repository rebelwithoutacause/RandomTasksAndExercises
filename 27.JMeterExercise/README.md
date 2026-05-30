# JMeter Load Testing: First Demo Test

This repository contains a basic **Apache JMeter** test plan designed to simulate dynamic load testing using parameterized user data. It includes reusable test elements, a CSV file for dynamic input, and a sample result plan.

## 📂 Project Structure

| File | Description |
|------|-------------|
| `First-demo-test.jmx` | The main JMeter test plan. It includes thread groups, samplers, listeners, and uses dynamic data from a CSV file. |
| `Results.jmx` | A JMeter test results file or an additional test plan. Can be used to compare or analyze test outputs. |
| `Dynamic-Data.csv` | A CSV file containing dynamic test data (e.g. usernames, passwords, emails, etc.) used via the CSV Data Set Config element. |

## 🚀 How to Run the Test

1. **Install Apache JMeter**  
   [Download JMeter](https://jmeter.apache.org/download_jmeter.cgi) and extract the archive.

2. **Open JMeter**  
   Launch JMeter using the `jmeter.bat` (Windows) or `jmeter.sh` (Linux/Mac) script.

3. **Load the Test Plan**  
   - Go to `File > Open` and select `First-demo-test.jmx`.
   - Make sure `Dynamic-Data.csv` is in the same directory or update the CSV path in the test plan.

4. **Run the Test**  
   - Press the green "Start" button (▶).
   - Use listeners like View Results Tree or Summary Report to monitor results.

5. *(Optional)* View or run `Results.jmx` for a different scenario or test output.

## 📌 Notes

- Designed for demo and educational purposes.
- Ensure the server/API endpoint used in the test plan is accessible before running.
- CSV parameterization allows testing with realistic user data.

---

## 🛠️ Technologies

- Apache JMeter
- CSV Parameterization
- Performance Testing

## 📧 Contact

For questions or feedback, feel free to reach out!

---

> **Tip:** You can use this test plan as a base for larger performance testing scenarios. Try adding assertions, timers, or logic controllers to enhance it!
