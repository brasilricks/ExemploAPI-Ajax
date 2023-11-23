var pagAnterior = ""
var pagProxima = ""
var urlBaseList = 'https://rickandmortyapi.com/api/character'
$(document).ready(function() {
	gerarLista(urlBaseList)
});

function popularTabela(volta, prox, characters){
	let lId = characters.id
	let lNome = (characters.name != 'unknown' ? characters.name : "")
	let lStatus = (characters.status != 'unknown' ? characters.status : "")
	let lGender = (characters.gender != 'unknown' ? characters.gender : "")
	let lUrlImage = (characters.image != 'unknown' ? characters.image : "")
	let urlLink = "/Home/DetalhesJS/" + characters.id;
	let lista = ""

	lista += "<tr>"
	lista += "<td>" + lNome + "</td>"
	lista += "<td>" + lStatus + "</td>"
	lista += "<td>" + lGender + "</td>"
	lista += "<td><img src='" + lUrlImage + "' /></td>"
	lista += "<td><a href='" + urlLink + "' class='btn btn-success'>Detalhes</a></td>"
	lista += "</tr>"
	$(".lista_content").append(lista);
	
	if(volta != "" && volta != null){
		$("#btmVoltar").removeClass('hidden')
		$("#btmVoltar").attr("value", volta)
	} else {
		$("#btmVoltar").addClass('hidden')
	}

	$("#btmProximo").attr("value", prox)
}

function LimparListaAtual(){
	$(".lista_content").empty();
}

function gerarLista(url){
	LimparListaAtual()
	$.ajax({
    url: url,
    success: function (data) {
			pagVoltar = data.info.prev
			pagProxima = data.info.next
            $.each(data.results, function(indice) {
				popularTabela(pagVoltar, pagProxima, data.results[indice])
            });
        },
    error: function (request, status, error) {
        alert("erro Ajax do gerador listas");
    }
   });
}

$("#btmProximo").click(function () {
	$(".lista_content").empty()
	value = $("#btmProximo").attr("value")
    gerarLista(value)
});

$("#btmVoltar").click(function () {
	$(".lista_content").empty()
	value = $("#btmVoltar").attr("value")
    gerarLista(value)
});

function BuscaGeral(name, status, gender){
	let url = "https://rickandmortyapi.com/api/character?name=" + name + "&status=" + status + "&gender=" + gender
	gerarLista(url)
}