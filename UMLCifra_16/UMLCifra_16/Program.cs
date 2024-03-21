using UMLCifra_16;

Manager mediator = new();
Personal waiter = new Waiter(mediator);
Personal cook = new Cook(mediator);
Personal cashier = new Cashier(mediator);
mediator.Waiter = waiter;
mediator.Cook = cook;
mediator.Cashier = cashier;
waiter.Send("Есть заказ, надо приготовить еды");
cook.Send("Еда готова, можно принимать оплату");
cashier.Send("Еда оплачена, можно подовать");