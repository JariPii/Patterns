## Composition

 ### Composition
  
 Composition involves creating complex objects by combining simpler objects or components.
 In composition, objects are assembled together to form larger structures, with each component
 object maintaining its own state and behavior. Composition is often described in terms of a
 "Has-A" relationship.
 
 ### Composition vs Inheritance

 #### When to use Composition

 When you need more felxibility in constructiong objects by assembling smaller, reusable
 components.
 When there is no clear "Is-A" relationship between classes, and a "Has-A" (Car has an Engine)
 relationship is more appropriate.
 When you want to avoid the limitations of inheritance, such as tight coupling and the fragile
 base class problem.

 #### When to use inheritance

 When there is a clear "Is-A" relationship between classesm and subclass objects can be treated as instances
 of their subclass. (A circl is a Shape)
 When you want to promote code to reuse by inheriting properties and behaviors from existing classes.
 When you want to leverage polymorphism to allow objects of different subclasses to be treated uniformly
 through their common superclasses interface.

 ### Fragile base class problem and why you should use composition over inheritance
 The fragile base class problem is a software design issue that arises in object-oriented
 programming when changes made to a base class can inadvertently break the functionality of
 derived classes. This problem occurs due to the tight coupling between base and derived classes
 in inheritance hierarchies.
 
 1. Inheritance Coupling: Inheritance creates a strong coupling between the base class(superclass) and
	derived classes(subclasses). Any changes made to the base class can potentially affect the
	behavior of all derived classes.
	
 2. Limited Extensibility: The fragile base class problem limits the extensibility  if the software
	systems, as modifications to the base class can become increasingly risky and costly over time.
	Developers may avoid making necessary changes due to the fear of breaking existing functionality
	-- Brittle software.
	
#### Mitigation Strategies

To mitigate the Fragile Base Class problem, software developers can use design principles such as the
Open/Close Principle (OCP) and Dependency Inversion Principle (DIP), as well as design patterns like
composition over inheritance. These approaches promote loose coupling, encapsulation and modular design,
reducing the impact of changes in base classes.