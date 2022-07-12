#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int	main(void)
{
	char	word[] = "hello";
	char	*result;
	int		i;
	int		j;

	i = 0;
	j = 0;
	//word = "Hello";
	result = malloc(sizeof(char) * strlen(word) + 1);
	if(!result)
		return (0);
	while(word[i])
	{
		while(word[i] == word[i + 1])
			i += 2;
		result[j] = word[i];
		printf("word[%d]:|%c| |%s|	result[%d]:|%c| |%s|\n", i, word[i], word, j, result[j], result);
		i++;
		j++;
	}
	result[j] = '\0';
	printf("\nFinished:|%s|\n", result);
	free(result);
}