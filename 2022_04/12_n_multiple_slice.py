# 다시 풀어야 댐 ㅎ

def solution(n, left, right):
    answer = []
    arr = []
    
    for i in range(n):
        # tmp = [i for i in range(n)]
        tmp = [i] * n
        for j in range(i+1,n):
            tmp.append(tmp[j-1]+1)
        arr.append(tmp)
            
    answer = sum(arr,[])
    
    return answer[left:right+1]


n = 4
left = 7
right = 14
print(solution(n, left, right))