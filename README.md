<h1 style="color:red; font-family:Arial; text-align:center;">Search Task</h1>

<h2 style="font-family:Arial; color:#333;">
  Q: When should I use a struct instead of a class?
</h2>

<h4 style="font-family:Arial; line-height:1.6; color:#444;">

<span style="font-weight:bold;">• It represents a value, not an object.</span><br>
<span style="margin-left:20px;">Like a number, coordinate, color, or date — no identity, only data matters.</span><br><br>

<span style="font-weight:bold;">• It is small in size.</span><br>
<span style="margin-left:20px;">Ideally under ~16–24 bytes.</span><br>
<span style="margin-left:20px;">Example: Point, Color, DateRange.</span><br><br>

<span style="font-weight:bold;">• It should be immutable.</span><br>
<span style="margin-left:20px;">The data shouldn’t change after creation.</span>

</h4>
