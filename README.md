
# QA Bootcamp Project – Manual & Automation Testing

This repository was created as part of the **Junior QA Test Engineer Bootcamp** assignment. It includes both manual and automation testing artifacts, designed to demonstrate understanding of software testing processes and best practices.

## 🔍 Project Overview

- **Website Under Test:** [https://opensource-demo.orangehrmlive.com](https://opensource-demo.orangehrmlive.com)
- **Tools Used:**
  - Selenium WebDriver (C#)
  - NUnit
  - Extent Reports
  - Excel (for manual test documentation)
- **Testing Types:**
  - Manual Test Design & Execution
  - UI Automation Testing

---

## 📁 Project Structure

```bash
QA-Bootcamp-Project/
│
├── QAWebAutomationTests/           # Automation test project
│   ├── Pages/                      # Page Object Model (POM) classes
│   ├── Tests/                      # Test classes (ValidLogin, InvalidLogin, Inventory)
│   ├── Utils/                      # Driver, ExtentReport, Screenshot helpers
│
├── Test Cases and Bug Reports.xlsx  # Manual test scenarios and example bug report
├── README.md                       # Project documentation
```

---

## ✅ Manual Test Documentation

- A detailed list of manual test cases has been created for `opensource-demo.orangehrmlive.com`.
- Each test case includes steps, expected results, actual results, and test status.
- An example bug report is also included, following standard bug reporting format (Title, Steps, Expected vs. Actual, Severity, etc.).

📄 File: `Test Cases and Bug Reports.xlsx`

---

## 🤖 Automated Tests

### Implemented Test Scenarios

| Test Name               | Description                                 |
|------------------------|---------------------------------------------|
| ValidLoginTest         | Tests login with correct credentials        |
| InvalidLoginTest       | Verifies login error message with wrong input |
| ProductsAreVisibleTest | Checks if products are visible post-login   |

- Tests use the **Page Object Model** design pattern.
- **Extent Reports** are generated after test execution.
- Screenshots are captured for pass/fail scenarios.

---

## 📊 Test Reporting

All automated tests generate Extent Reports saved under the project directory after execution.

---

## 🔧 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/ismailaydemirx/QAWebAutomationTests
   ```

2. Open the solution in **Visual Studio**.

3. Restore dependencies and build the project.

4. Run tests using **Test Explorer** or via terminal using `dotnet test`.

---

## 📬 Submission Info

- **Submitted by:** İsmail Aydemir
- **Bootcamp:** Junior QA Test Engineer
- **Submission Date:** May 8, 2025

---

## 📫 Contact

For any questions or clarifications, feel free to reach out.

---
