Feature: FlipkartDemo

Background: 
Given I launch Browser

@smoke
Scenario Outline: Verify Search operation iphone_Smoke
	Given I navigate to "http://www.flipkart.com" web site
	When I perform search with "<SearchString>"
	Then The result should be displayed
Examples: 
| SearchString    |
| Apple iphone 5s |


@Regression
Scenario Outline: Verify Search operation iphone_Reg
	Given I navigate to "http://www.flipkart.com" web site
	When I perform search with "<SearchString>"
	Then The result should be displayed
Examples: 
| SearchString    |
| Apple iphone 5s |
| Apple iphone 4  |
| Apple iphone 6s |


Scenario: Verify Search operation iphone table
	Given I navigate to "http://www.flipkart.com" web site
	When I perform search and results are displayed
	| SearchString    | Results |
	| Apple iphone 4s | 10      |
	| Apple iphone 5s | 20      |
	| Apple iphone 6s | 30      |
	
