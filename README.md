# SymmetricDifference

The mathematical term symmetric difference (△ or ⊕) of two sets is the set of elements which are in either of the two sets but not in both. For example, for sets A = {1, 2, 3} and B = {2, 3, 4}, A △ B = {1, 4}.

sym([1, 2, 3], [5, 2, 1, 4]) should return [3, 4, 5].

sym([1, 2, 3], [5, 2, 1, 4]) should contain only three elements.

sym([1, 2, 3, 3], [5, 2, 1, 4]) should return [3, 4, 5].
