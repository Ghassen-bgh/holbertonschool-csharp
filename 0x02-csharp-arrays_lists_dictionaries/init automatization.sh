#!/usr/bin/env bash
declare -a my_array
my_array=(0-print_array 1-element_at 2-replace_element 3-print_array_reverse 4-print_list 5-max_integer 6-divisible_by_2 7-delete_at 8-number_keys 9-add_key_value 10-delete_key_value 11-multiply_by_2 12-print_sorted_dictionary 13-best_score 14-rectangular_array 15-square_matrix)
for i in "${my_array[@]}"
do
dotnet new console --language "C#" --output "$i"
mv "$i"/"Program".cs "$i"/"$i".cs
done
