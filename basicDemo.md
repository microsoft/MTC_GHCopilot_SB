# Basic Copilot demo

Assume we're tasked with creating a REST API that takes in an order for our product, prepares it for additional processing such as db persistence, etc, then responds to the caller with a valid response.  Using Copilot:
* Code completion
* Test case generation
* Code documentation

We'll implement a REST handler, serialize the payload into an object, respond to the caller with valid response, write test cases and document the fuctionality as well as use Copilot to fix any problems along the way.


### 1. Create the required functionality using code completion

Beginning with the stubbed class for an HTTP trigger function.  Using an inline comment, prompt Copilot to generate an Order class containing the relevant fields for our order object:

        // create a class to hold a productID string, an orderID string and a quantity int


![Create Order class](./media/basicDemo/1_codegen_createorder.png)

Copilot creates an Order class:

![Order class](./media/basicDemo/2_codegen_createorder.png)

Convert the incoming request body to a string:

    // convert request body into a string

![Request body to string](./media/basicDemo/3_codegen_request.png)

Create a method that deserializes the request string into our Order object:

    // write a method to convert the request body into an order object

![Convert method](./media/basicDemo/4_codegen_method.png)

Use the new method to convert the payload:

    // convert request body into an order object

![Convert body](./media/basicDemo/5_codegen_convert.png)

Return an Order Recieved message to the caller containing the original payload, this time using Copilot Chat companion:

    // return a JSON string response containing the message "Order Received" and names and values of the order

![Create response](./media/basicDemo/6_codegen_response.png)

Assume that a change was introduced to the code that boke its functionality.  Fix this by highlighting the code, through the Copilot conext menu, choose Fix:

![Code error](./media/basicDemo/7_codegen_error.png)

![Fix code error](./media/basicDemo/8_codegen_fix.png)

### 2. Generate test case using test case generation

Again using the Copilot context menu, highlight the target code and choose Generate Tests:

![Generate tests](./media/basicDemo/9_testgen1.png)

A test class is generated:

![Generate tests](./media/basicDemo/10_testgen2.png)

### 3. Document the class using documentation generation

Using the Copilot context menu, highlight the target code and choose Generate Docs:

![Generate documentation](./media/basicDemo/11_docgen1.png)

Documentation is created:

![Documentation created](./media/basicDemo/12_docgen2.png)

### 4. Optionally test the code to demonstrate end-to-end functionality

![End-to-End test](./media/basicDemo/13_testrun.png)