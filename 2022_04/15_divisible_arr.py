# 프로그래머스 나누어 떨어지는 숫자 배열
def solution(arr, divisor):
    answer = []
    
    for a in arr:
        if (a % divisor) == 0:
            answer.append(a)
    
    if not answer:
        answer.append(-1)
    
    answer.sort()
    
    return answer