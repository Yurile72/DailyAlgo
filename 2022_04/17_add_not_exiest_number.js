// 프로그래머스 없는 숫자 더하기
// 다른 언어로는 어렵냐,,,

function solution(numbers) {
  var answer = 0;

  // numbers.sort();
  // for (i = 0; i < 10; i++) {
  //     if (numbers.indexOf(i) == -1)
  //         answer += i
  // }

  for (i = 0; i < 10; i++) {
    if (!numbers.includes(i)) answer += i
  }

  return answer
}