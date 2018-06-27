# CoverletAwaitBranchCoverage
Repro for coverlet generating partial branch for await Task.CompletedTask

This is the coverlet console output:
```
Calculating coverage result...
  Generating report 'C:\code\CoverletAwaitBranchCoverage\CoverletAwaitBranchCoverageTest\coverage.json'

+-----------------------------+--------+--------+--------+
| Module                      | Line   | Branch | Method |
+-----------------------------+--------+--------+--------+
| CoverletAwaitBranchCoverage | 100%   | 50%    | 100%   |
+-----------------------------+--------+--------+--------+

+---------+--------+--------+--------+
|         | Line   | Branch | Method |
+---------+--------+--------+--------+
| Average | 100%   | 50%    | 100%   |
+---------+--------+--------+--------+
```
