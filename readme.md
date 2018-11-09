# `reset-LogiRegistryService`

Logitech's `LogiRegistryService` can eat up a lot of memory if left running for days. `reset-LogiRegistryService` restarts the service to free up that memory.

* Move `reset-LogiRegistryService.exe` somewhere useful.
* Import `Restart LogiRegistryService.xml` into Task Scheduler.
  * Update the account. They need to be an Administrator and you need a password.
  * Update the action. Set it to point to the executable.
  * Update the trigger. Currently, it's set for once a day at 5am.
  * When you click OK, you'll need to enter the account's password.
