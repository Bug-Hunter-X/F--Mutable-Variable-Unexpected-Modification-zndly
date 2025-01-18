# F# Mutable Variable Unexpected Modification

This example demonstrates a common issue in F# when working with mutable variables. The `addOne` function modifies the mutable variable `x` globally, leading to unexpected results. The `result` variable is correctly updated, but the global `x` is also changed, causing confusion.

## How to Reproduce

1. Run the code in a F# interpreter.
2. Notice that the output shows that the global value of `x` has changed, even though the `addOne` function seems to only return a new value.