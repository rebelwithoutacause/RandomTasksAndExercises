# k6 Load Testing Scripts

This repository contains example load testing scripts using [k6](https://k6.io/).  
It demonstrates how to run performance tests on different endpoints and export results as an interactive **HTML report**.

## 📂 Project Structure
📁 k6_Testing
├── first-script.js # Main test script
├── summary.html # Auto-generated report after running the test
└── README.md # Documentation

## 🚀 Requirements
- [k6](https://k6.io/docs/getting-started/installation/) installed  
- Internet connection to access test endpoints  
- (Optional) Git for version control  

## 📝 Script Overview
The example script:
- Simulates **10 virtual users (VUs)** for **10 seconds**
- Sends GET requests to the target endpoint(s)
- Generates a detailed **HTML report** after the run

## ▶️ How to Run
1. Open a terminal in the script’s directory
2. Run:
   ```bash
   k6 run first-script.js
3. After the test finishes, a file named summary.html will be created in the same directory

📊 Viewing the Report

Simply open summary.html in your browser to view:

Request durations

Failure rates

Requests per second

Data transfer stats

Percentile breakdowns
