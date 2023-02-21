# composite-pattern
also known as object tree

Component
this is the main abstract class for leaves. 

Leaf
creating leaves like creating the base objects. 
think about the company which is basically created by human beings
overrides an abstract method from component

Composite
composite is created by leaves. Department is also a composite as it contains several employee



think about the gift box example

component => giftbase
leaf => toy
composite => toy box (can contain several toys)

final gift can contain also several toy box but to calculate overall cost you will depend on toy costs 
