### Payment Gateway Sub System
paymentgateway: responsible for processing payment requests and posting responses.
(in real world, would be responsible for Timeout reversals ETC...)

The main APIs are exposed in DDDTraining.PaymentGateway.BackEnd.APIs and is pseudo-implemented as a function listening to some messages on a queue: see AuthorizationRequestEvent and AuthorizationResponseEvent where an attempt to use duck typing is made.

The main model is exposed in DDDTraining.PaymentGateway.Models and is centered around the AuthorizationRequest and AuthorizationResponse objects.

### Diagram
The domain model is described in DDDTraining.PaymentGateway.Models and is centered around the AuthorizationRequest and the AuthorizationResponse entities: see ClassDiagram.cd in Visual Studio.
