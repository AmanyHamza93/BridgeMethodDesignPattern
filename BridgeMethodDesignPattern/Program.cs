using BridgeMethodDesignPattern;

Vehicle vehicle1 = new Car(new Produce(), new Assemble());
Vehicle vehicle2 = new Bike(new Produce(), new Assemble());
vehicle1.Manufacture();
vehicle2.Manufacture();
