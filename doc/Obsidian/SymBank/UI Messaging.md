- Intrusive (Message dialog)
- Non-intrusive (Notification, status message)


To access UI services:

```C#
var shell = ServiceRepository.Get<IShell>();
shell.Status = "Operation completed.";
shell.Failure("An error has occurred");

```
