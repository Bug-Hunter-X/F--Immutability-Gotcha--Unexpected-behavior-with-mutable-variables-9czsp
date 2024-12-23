# F# Immutability Gotcha: Unexpected Behavior with Mutable Variables

This example demonstrates a common pitfall in F#: unexpected behavior when mixing mutable and immutable variables.  The `result` variable is calculated only once, initially, even if the values of `x` and `y` change later. This is because F# values are immutable unless explicitly declared `mutable`.

The `bug.fs` file shows the problematic code. The `bugSolution.fs` file offers a correction using a function to dynamically calculate the sum.

This example highlights the importance of understanding F#'s immutable nature, especially for developers familiar with languages that heavily rely on mutable variables.