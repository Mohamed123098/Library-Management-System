<h1 style="color :red;">Search task</h1>
<h2> Q:When should I use a struct instead of a class?</h2>
<h4>
  It represents a VALUE, not an object
Like a number, coordinate, color, date
No identity — only data matters
It is SMALL
Ideally under ~16–24 bytes
Example: Point, Color, DateRange
It should be IMMUTABLE
Data shouldn’t change after creation
</h4>
