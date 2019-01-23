/*Bob's Burgers sells Burgers ($2.99), Fries($1.99) and Drinks($.99) or a Bobby Meal (a burger, fry and drink $5.00)
An order can be made up of 1 or more items in any combination
A user should be asked if they would like to add more items to their order
A user input should be validated
The user should be presented with a menu from which to choose their item and the item should reprint after each selection
The total cost should be presented to the user when they have answered they do not want to order another item.
When accumulating the cost of the food you would use something like subTotal = subTotal + itemPric
*/
//setup
int burgers = 0;
int fries = 0;
int drinks = 0;
int bobbyMeal = 0;
string answer = String.Empty;
double subTotal =0.0;
double taxTotal = 0.0;
double grandTotal =0.0;
int quantity =0;
//input
" Please select the number from following items: 1) Burgers $2.99 2)Fries $1.99 3)Drinks$.99 4) Bobby Meal (a burger, fry and drink $5.00)"
Get orderNumber; //validate that numeric value is between 1 and 4
" How many of" +1 +" do you want?"
Get quantity;
"Do you want to add anything else to your order?"
Get answer; //validate user answer if they want to add item YES/NO
//process
if (orderNumber ==1)
    burgers = burgers + quantity;
    
    subTotal = subTotal+2.99*quantity;
else if (orderNumber ==2)
    fries = fries + quantity;
    subTotal = subTotal+1.99*quantity;
else if (orderNumber == 3)
    drinks = drinks + quantity
    subTotal = subTotal+.99*quantity;
    
else if (orderNumber == 4)
    bobbyMeal = bobbyMeal + quantity;
    subTotal = subTotal+5.00*quantity;
taxTotal = 6.875f * subTotal;
grandTotal = taxTotal+subTotal;
//output
if ( burgers >0)
    "Total number of burgers is "+ burgers + " And the total is $"+burgers*2.99f
    else if (fries >0)
    "Total number of fries is "+ fries + " And the total is $"+fries*1.99f
else if (drinks)
    "Total number of drinks is "+ drinks + " And the total is $"+drinks*.99f
else if (bobbyMeal >0)
    "Total number of bobbyMeal is "+ bobbyMeal + " And the total is $"+bobbyMeal*5.00f