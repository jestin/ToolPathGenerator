#Service

This is the service layer of the tool path generator.  It is the project that does all the heavy lifting.  Anything in this layer needs to be abstracted away with interfaces so that it can be called by more "outer" layers of the application.  This is the layer the contains base data models, helper classes, and all the components that are required for tool path generation.