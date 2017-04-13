# Pokemon-Toy-Store

You work in a toy store that is selling Pokemon. Customers who buy more than one type of Pokemon get a

discount. The same type of Pokemon cannot be added to a discount group.

Number of Different Pokemon                   Discount Amount
Purchased

1                                             No discount

2                                               10%

3                                               20%


Pokemon for Sale                                Price

Pikachu                                           $6

Squirtle                                          $5

Charmander                                        $5


<h2>Requirements</h2>

The completed program should be able to calculate the best possible discount for any collection of Pokemon.
You may use multiple transactions to get the best price.

Each example should be translated into a Unit Test. No UI component is required, each test scenario may be
hard coded. Additional Unit Tests are encouraged.

<h2>Test Cases </h2>

<h3>Example One</h3>

Purchased 1 Pikachu
Should yield $6.00

<h3>Example Two</h3>

Purchased 2 Pikachu
Should yield $12.00

<h3>Example Three</h3>

Purchased 1 Pikachu
Purchased 1 Squirtle
Should yield $9.90

<h3>Example Four</h3> *note that each group of two Pokemon receives a 10% discount.

Purchased 2 Pikachu
Purchased 2 Squirtle
Should yield $19.80 *2x Example 3 => $9.90 + $9.90 = $19.80

<h3>Example Five</h3> *note that each group of two Pokemon receives a 10% discount.

Purchased 3 Pikachu
Purchased 3 Squirtle
Should yield $29.70 *3x Example 3 => $9.90 + $9.90 + $9.90 = $29.70

<h3>Example Six</h3> *note that the 10% discount does not apply to the second Pikachu.

Purchased 2 Pikachu
Purchased Squirtle
Should yield $15.90

<h3>Example Seven</h3>

Purchased 1 Pikachu
Purchased 1 Squirtle
Purchased 1 Charmander
Should yield $12.80

<h3>Example Eight</h3> *note that the 20% discount applies to the three grouped Pokemon, but not the additional

ungrouped Pikachu.
Purchased 2 Pikachu
Purchased 1 Squirtle
Purchased 1 Charmander
Should yield $18.80
