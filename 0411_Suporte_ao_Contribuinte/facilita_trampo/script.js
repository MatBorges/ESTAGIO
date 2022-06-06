
let lines = document.querySelectorAll(".lines")
let addBtn = document.querySelectorAll(".addDiv")
let containners = document.querySelectorAll(".cardContainner")
let resultLine = document.querySelector(".valueResult")
let tamanhoTotal = document.querySelector(".tamanhoTotal")

function creatingCard() {
  const newCard = document.createElement("div")
  const newCardHTML = `<div class="card">
                        <input type="text" name="columnName" class="columnName" placeholder="Coluna">
                        <input type="number" name="columnLength" class="columnLength" placeholder="Comprimento">
                        <input type="text" name="columnFill" class="columnFill" placeholder="Preenchimento">
                        <input type="text" name="columnValue" class="columnValue" placeholder="Valor">
                        <button class="adicionar">Adicionar</button>
                       </div>`
  newCard.innerHTML = newCardHTML
  return newCard
}

function addingColumn() {
  let column = document.querySelectorAll(".adicionar")
  console.log(column)
  for(btnAdd of column) {
    btnAdd.addEventListener('click', () => {
      let valuesList = {
        name: [],
        length: [],
        fill: [],
        value: []
      }
      let columnName = document.querySelectorAll(".columnName")
      let columnLength = document.querySelectorAll(".columnLength")
      let columnFill = document.querySelectorAll(".columnFill")
      let columnValues = document.querySelectorAll(".columnValue")
      console.log(columnValues)
      
      for(i = 0; i < columnName.length; i++) {
        valuesList["name"].push(columnName[i].value)
        valuesList["length"].push(columnLength[i].value)
        valuesList["fill"].push(columnFill[i].value)
        valuesList["value"].push(columnValues[i].value)
      }
      setValueList(valuesList)
    })
  }
}
function setValueList(lista) {
  let allStrings = ''
  let eachDiv = []
  for(i = 0; i < lista["name"].length; i++) {
    let resultStr = lista["fill"][i].repeat(parseInt(lista["length"][i]) - lista["value"][i].length)
    resultStr += lista["value"][i]
    allStrings += resultStr
    const newDiv = document.createElement("pre")
    
    let r = Math.floor(Math.random() * 256)
    let g = Math.floor(Math.random() * 256)
    let b = Math.floor(Math.random() * 256)

    newDiv.style.color = `rgb(${r}, ${g}, ${b})`
    newDiv.textContent = resultStr
    eachDiv.push(newDiv)
  }
  // resultLine.textContent = allStrings
  resultLine.innerHTML = ''
  for(i of eachDiv) {
    resultLine.append(i)
  }
  tamanhoTotal.textContent = allStrings.length
  // console.log(eachDiv)
}

// Adding new columns
for(singleAdd of addBtn) {
  singleAdd.addEventListener("click", function() {
    containners[0].insertBefore(creatingCard(), addBtn[0])
    addingColumn()
  })
}
// Creating horizontall scroll
containners[0].addEventListener("wheel", (evt) => {
  evt.preventDefault()
  containners[0].scrollLeft += evt.deltaY
})  