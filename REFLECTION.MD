De Vera, Alliyah Alcel G.
BSIT 31E1

Why did you use inheritance?
I used inheritance because Car, Airplane, Boat, Helicopter all share the same Vehicle category. 

Why did you use interfaces?
I used interface because they represent capabilities of driving, flying, sailing. These are the actions of what a class can do.

Could Helicopter inherit from both Vehicle and Airplane? Why or why not? 
No, because in C# it cannot inherit two or more classes. A class can only inherit one class. This is why Helicopter can inherit from Vehicle but cannot inherit from Airplane.

Why can Helicopter implement both IFlyable and IDriveable?
Because in C# a class can inherit multiple interfaces. This is why Helicopter can both fly and drive while inheriting from only one base class.

If a Submarine can both sail and dive, how would you design it?
I would create another class called "Submarine" that inherits from Vehicle and implements both "ISailable" and "IDriveable."
