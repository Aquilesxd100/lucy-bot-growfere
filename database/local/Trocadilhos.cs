using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bot_lucy_growfere.database.local
{
    public class ITrocadilho
    {
        public string _pergunta;
        public string _resposta;
        public ITrocadilho(string pergunta, string resposta)
        {
            _pergunta = pergunta;
            _resposta = resposta;
        }
    }
    public class Trocadilhos
    {
        public static List<ITrocadilho> data = new List<ITrocadilho>{
        new ITrocadilho(
            "Quais heróis se preocupam mais com as poses para fotos do que com salvar o seu planeta?",
            "Os TumblrCats"
        ),
        new ITrocadilho(
            "Qual é a profissão do Homem Aranha?",
            "Desenvolvedor Web"
        ),
        new ITrocadilho(
            "Qual é o estado dos EUA que te eletrifica?",
            "Ohio."
        ),
        new ITrocadilho(
            "Por que o monge foi ao hospital?",
            "Porque ele é paciente."
        ),
        new ITrocadilho(
            "Qual o time mais quente de todos?",
            "Bota-fogo."
        ),
        new ITrocadilho(
            "Por que o cachorro ia pra escola todos os dias?",
            "Porque ele tinha auaula."
        ),
        new ITrocadilho(
            "Qual o produto tensoativo que sabe de tudo?",
            "Sabão."
        ),
        new ITrocadilho(
            "Quem é o rei dos produtos de espantar insetos?",
            "É o Rei-pelente."
        ),
        new ITrocadilho(
            "Por que o magrelo tem que tomar banho com os braços abertos?",
            "Para não ser engolido pelo ralo."
        ),
        new ITrocadilho(
            "Qual o ator que livra as pessoas das dores?",
            "Malvino Salva-dor."
        ),
        new ITrocadilho(
            "Por que as vogais A, E, I e O foram rejeitadas pela banda Scorpions?",
            "Porque eles Still Love U."
        ),
        new ITrocadilho(
            "Qual a carne que é cheia de panos?",
            "Frango Empanado."
        ),
        new ITrocadilho(
            "Por que o Papai Noel não tem assadura?",
            "Porque seu saco já é vermelho."
        ),
        new ITrocadilho(
            "Qual é a bebida que corre?",
            "Rum."
        ),
        new ITrocadilho(
            "Você está em uma estrada e vê vários postos um perto do outro. Por que isso acontece?",
            "Porque os-postos se atraem."
        ),
        new ITrocadilho(
            "Qual animal não gosta do amanhã?",
            "Rinocer-ontem."
        ),
        new ITrocadilho(
            "O que acontece se um panda tiver vários filhotes?",
            "Vira uma pandemia."
        ),
        new ITrocadilho(
            "Qual a fruta predileta da cigana?",
            "O Li Mão."
        ),
        new ITrocadilho(
            "Qual é o tipo de música favorito dos mortos?",
            "R.I.P-Hop."
        ),
        new ITrocadilho(
            "O que é que tem no meio do ovo?",
            "A gema."
        ),
        new ITrocadilho(
            "Por que a loira entrou com muitos espelhos na faculdade de engenharia?",
            "Porque ela é engenheira se-viu."
        ),
        new ITrocadilho(
            "Qual é a cantora que não se adapta ao meio urbano?",
            "Vanessa da Mata."
        ),
        new ITrocadilho(
            "Qual é o super-herói que toma chá e depois dá um salto pequeno?",
            "Chá-pulinho."
        ),
        new ITrocadilho(
            "Qual é a ave que está sempre enrijecida?",
            "An-durinha."
        ),
        new ITrocadilho(
            "Qual é a ave que serve de automóvel para um parasita aracnídeo?",
            "Carro-a-pato."
        ),
        new ITrocadilho(
            "Porque o principal narrador esportivo da Globo adora narrar jogos da Argentina?",
            "Porque é Galvão Buenos-Aires."
        ),
        new ITrocadilho(
            "Que tipo de negócio abriram os ursos da China?",
            "Uma pandaria."
        ),
        new ITrocadilho(
            "Qual o filósofo favorito do cavalo?",
            "Trotsky."
        ),
        new ITrocadilho(
            "Qual é a ferramenta que sempre aponta onde as pessoas e coisas estão?",
            "Ali-cate."
        ),
        new ITrocadilho(
            "O que o leitão foi fazer na loja de parafusos?",
            "Foi procurar a porca."
        ),
        new ITrocadilho(
            "O que o boi respondeu para a vaca, quando ela o perguntou se ele gostava bastante dela?",
            "Muuuuuuuuuuuuito!"
        ),
        new ITrocadilho(
            "Como se chama o campeonato de anedotas?",
            "Olim-piadas."
        ),
        new ITrocadilho(
            "Qual a reação de um mecânico depois de contarem uma piada sem graça para ele?",
            "Dizer que não achou graxa nenhuma."
        ),
        new ITrocadilho(
            "Qual o tipo de violência que o super-herói do martelo não admite?",
            "A Thortura."
        ),
        new ITrocadilho(
            "Qual a doença do sacristão?",
            "Sinus-ite."
        ),
        new ITrocadilho(
            "Por que temos vacas e bois próximos ao nosso estômago?",
            "Porque temos o intestino deu-gado."
        ),
        new ITrocadilho(
            "Qual o tipo de pessoa o Papai Noel gosta?",
            "De puxa-saco."
        ),
        new ITrocadilho(
            "Qual é o ramo da medicina que faz uma ligação para a irmã de sua mãe?",
            "Alopatia."
        ),
        new ITrocadilho(
            "O que acontece se um panda tiver vários filhos?",
            "Ele vira um pandeiro."
        ),
        new ITrocadilho(
            "Quando é que o Renato Aragão acorda?",
            "Didi-a."
        ),
        new ITrocadilho(
            "O que é que, quando o pai nasce a filha já esta andando?",
            "Fumaça."
        ),
        new ITrocadilho(
            "Qual é o time mais odiado pelo os bombeiros?",
            "Botafogo"
        ),
        new ITrocadilho(
            "O que você deve fazer quando estiver triste?",
            "Abraçar o sapato, porque o sapato com-sola."
        ),
        new ITrocadilho(
            "Qual o carro em que o Cebolinha manda as pessoas pararem?",
            "Ô-Pala."
        ),
        new ITrocadilho(
            "Você sabe qual é a comida preferida do topógrafo?",
            "Frângulo."
        ),
        new ITrocadilho(
            "Como se fala bombeiro em japonês?",
            "Takágua Naxama."
        ),
        new ITrocadilho(
            "Qual a rede social que os mineiros mais usam?",
            "Uaitsapp."
        ),
        new ITrocadilho(
            "Qual é o nome da pedra falante?",
            "Sei lá, pergunta pra ela, ela fala!"
        ),
        new ITrocadilho(
            "Qual é a massa do caderno?",
            "A massa folhada."
        ),
        new ITrocadilho(
            "Três mulheres estavam com picolés nas mãos. Uma estava chupando o picolé, outra estava mordendo o picolé e outra estava lambendo o picolé. Qual delas era a casada?",
            "A que estava com anel no dedo."
        ),
        new ITrocadilho(
            "Qual o banco em que uma letra se transforma em outra letra?",
            "É o I-tá-U."
        ),
        new ITrocadilho(
            "Qual a fruta que é parente da porta?",
            "É a Maçã-Neta."
        ),
        new ITrocadilho(
            "Qual é a peça de roupa preferido do Thor?",
            "PaleThor."
        ),
        new ITrocadilho(
            "Qual a cantora que é o primeiro alce do mundo?",
            "Alce-One."
        ),
        new ITrocadilho(
            "Um bêbado estava na rua quando chegou um carro e buzinou. O que o bêbado respondeu?",
            "Eu também bibi."
        ),
        new ITrocadilho(
            "Qual a diferença entre a cachaça e a mulher?",
            "A cachaça dá dor de cabeça só um dia."
        ),
        new ITrocadilho(
            "Por que o português jogou o arroz inteiro do pacote dentro do pote de açúcar?",
            "Para comer arroz doce."
        ),
        new ITrocadilho(
            "Por que os lustres não prestam atenção para escuridão?",
            "Porque eles tem focos luminosos."
        ),
        new ITrocadilho(
            "O que é um cachorro afinado, que entende de música?",
            "É um cãotor."
        ),
        new ITrocadilho(
            "O que é um objeto cortante em poder de um cachorro?",
            "Um cão-nivete."
        ),
        new ITrocadilho(
            "Por que o maior dramaturgo de língua inglesa é considerado um cavalheiro quando tenta ir ao banheiro, mas está ocupado?",
            "Porque quando ele bate e respondem que tem gente, ele dizem seguia= Shake-espera."
        ),
        new ITrocadilho(
            "Por que na cidade de Palmas as mulheres nunca conseguem molhar o cabelo?",
            "Porque lá elas usam Touca-ntins."
        ),
        new ITrocadilho(
            "Por que a loira pediu um envelope redondo no escritório onde trabalha?",
            "Porque seu chefe a pediu para entregar uma circular."
        ),
        new ITrocadilho(
            "Qual o veículo que é mulher do lanche?",
            "Lancha."
        ),
        new ITrocadilho(
            "O tio de Pedro tem 4 filhas, Lala, Lele, Lili, Lolo. Qual falta?",
            "Nenhuma, porque já tem 4."
        ),
        new ITrocadilho(
            "Qual o molho de tomate preferido dos gatos?",
            "É o Cat-chup."
        ),
        new ITrocadilho(
            "Qual o eletrodoméstico do vulcão?",
            "É a máquina de lava."
        ),
        new ITrocadilho(
            "Um homem levou um pedaço de queijo pro hospício e um dos pacientes subiu em cima do queijo. Qual o nome da série?",
            "Um Maluco no Pedaço."
        ),
        new ITrocadilho(
            "O que pensaram os outros convidados quando viram o Zangado chegar na festa sem a Branca de Neve?",
            "Ah, Não!"
        ),
        new ITrocadilho(
            "Qual o campeonato que tira as suas dores?",
            "Liberta-dores"
        ),
        new ITrocadilho(
            "Qual é a vestimenta preferida do Batman?",
            "Bat-ina."
        ),
        new ITrocadilho(
            "Por que um atleta dormiu na balança de uma farmácia?",
            "Para que quando acordasse fizesse um levantamento de peso."
        ),
        new ITrocadilho(
            "Qual o peixe que é parceiro de todo mundo?",
            "Truta."
        ),
        new ITrocadilho(
            "Por que as roupas amassadas se estenderam sobre o trilho?",
            "Porque lá passa o Trem de Ferro."
        ),
        new ITrocadilho(
            "Qual o médico que as pessoas atiram compostos orgânicos?",
            "Geraldo Álcool-Em-Mim."
        ),
        new ITrocadilho(
            "Como se diz veterinário em japonês?",
            "Kuragato Nakasa."
        ),
        new ITrocadilho(
            "Qual é o alimento preferida do Thor no natal?",
            "Pane-Thor-ne."
        ),
        new ITrocadilho(
            "Qual é o aparelho digital preferido do Thor?",
            "LapTHORp."
        ),
        new ITrocadilho(
            "Por que a loira leva sabonete e shampoo pro pé de manga?",
            "Porque ela gosta de tomar banho de mangueira."
        ),
        new ITrocadilho(
            "Qual a explosão que o Renato Aragão mais tem medo?",
            "É a Didi-namite."
        ),
        new ITrocadilho(
            "O que a Oceania e a novela tem em comum?",
            "Que a Oceania é O Outro Lado do Mundo e a novela é O Outro Lado do Paraíso."
        ),
        new ITrocadilho(
            "O menino estava assistindo desenho, e seu pai sem querer resvala na tomada e acaba desligando a TV. Qual o nome do desenho?",
            "Pô-pai."
        ),
        new ITrocadilho(
            "Qual é a fruta que termina primeiro do que todas as outras?",
            "Jabuti-acaba."
        ),
        new ITrocadilho(
            "Qual é o urso que nunca envelhece?",
            "Peter-Panda."
        ),
        new ITrocadilho(
            "Porque o urso começou a se coçar de repente?",
            "Porque ele era um urso empolar."
        ),
        new ITrocadilho(
            "Um americano perguntou para o bom velhino do natl= Papai, o senhor está bem?",
            "No well, respondeu o senhor..."
        ),
        new ITrocadilho(
            "O que disse uma pessoa após ter descoberto que havia comprado um óculos sem as lentes?",
            "Cuidado, é armação..."
        ),
        new ITrocadilho(
            "Por que as senhoras que vão à piscina gostam tanto de Helmmans?",
            "Porque elas só ficam de maiô-nesse."
        ),
        new ITrocadilho(
            "Porque todos os tipos de carne não toleram os bifes macios?",
            "Porque elas são contra-filé."
        ),
        new ITrocadilho(
            "Qual o estado brasileiro que anda de trem?",
            "Piauiiiiiiiiiiiiiiii."
        ),
        new ITrocadilho(
            "Como a família portuguesa que mora no Brasil parou de gastar com oftalmologista?",
            "Mudando-se para Boa-Vista."
        ),
        new ITrocadilho(
            "Qual é a capital brasileira que ensina a irmã a latir?",
            "Mana, au-aus."
        ),
        new ITrocadilho(
            "Qual a cidade mais amarela do mundo?",
            "Yellows Angeles."
        ),
        new ITrocadilho(
            "Qual é o cantor que poderia ser ortopedista?",
            "Caetano Vê-o-osso."
        ),
        new ITrocadilho(
            "Qual o carro mais azedo que existe?",
            "Limão-zine."
        ),
        new ITrocadilho(
            "Por que um jardineiro estava cavando o chão da vila do Chaves?",
            "Porque ele queria achar o tesouro."
        ),
        new ITrocadilho(
            "Qual o problema de saúde que nenhum anão terá?",
            "Pressão alta."
        ),
        new ITrocadilho(
            "Qual é a fruta favorita dos maquinistas?",
            "Kiwiiiiiiiiiiiiiii!!!"
        ),
        new ITrocadilho(
            "Qual é a fruta que ameniza o calor de Ana?",
            "Abana-Ana."
        ),
        new ITrocadilho(
            "Por que o estádo do Grêmio tem muitas abelhas?",
            "Porque Pedro Gerou-o-mel."
        ),
        new ITrocadilho(
            "Dois textos eram incompletos e estavam participando de alguns campeonatos de futebol, o que um disse pro outro?",
            "Precisamos de título."
        ),
        new ITrocadilho(
            "Qual o apresentador que tem olfato de animal?",
            "Rodrigo Faro."
        ),
        new ITrocadilho(
            "Qual é o carro do exército?",
            "Kadett."
        ),
        new ITrocadilho(
            "Qual é a crença ou religião que está sempre conectada à internet?",
            "A Umbanda Larga."
        ),
        new ITrocadilho(
            "Qual é o lugar da igreja que o Batman mais gosta?",
            "Bat-istério."
        ),
        new ITrocadilho(
            "Qual é o animal preferido do Thor?",
            "OrniThorrinco."
        ),
        new ITrocadilho(
            "Meu fim me leva ao começo ou o inexiste, sou um caminho sem fim, oque eu sou?",
            "Um paradoxo."
        ),
        new ITrocadilho(
            "Estou à sua volta, moro em seu coração, mas não posso ser compartilhado. O que eu sou?",
            "A solidão. Qualquer outro sentimento e até mesmo a sabedoria e conhecimento pode ser compartilhado."
        ),
        new ITrocadilho(
            "Por que a loira comeu o telhado da casa?",
            "Porque ela era comi-lona."
        ),
        new ITrocadilho(
            "Por que o anão não escuta o outro?",
            "Porque ele fala baixinho."
        ),
        new ITrocadilho(
            "Qual o time de futebol em que um chinês observa um jogo de sinuca?",
            "Lee-ver-pool."
        ),
        new ITrocadilho(
            "Qual o animal preferido do Renato Aragão?",
            "Didi-nossauro."
        ),
        new ITrocadilho(
            "Qual time de futebol larga na frente?",
            "Na-Pole."
        ),
        new ITrocadilho(
            "Qual a atriz que faz cópias de imagens?",
            "Gisele Print."
        ),
        new ITrocadilho(
            "Qual o lugar onde as pessoas mais fazem churros?",
            "Na enxurrada."
        ),
        new ITrocadilho(
            "Qual é a função do Thor?",
            "CorreThor."
        ),
        new ITrocadilho(
            "Qual país que se você pisar, será preso?",
            "Cana-dá."
        ),
        new ITrocadilho(
            "Um jogador de futebol apareceu e virou líder de um time de um programa de domingo da Globo. Qual o nome do filme?",
            "Capitão Fantástico."
        ),
        new ITrocadilho(
            "O que o goleiro utiliza para dormir?",
            "Trave-sseiro."
        ),
        new ITrocadilho(
            "Qual o aparelho luminário preferido do Thor?",
            "RefleThor."
        ),
        new ITrocadilho(
            "Qual o animal mais fuxiqueiro que existe?",
            "A fo-foca."
        ),
        new ITrocadilho(
            "Qual é o animal peçonhento que trabalha com montaria?",
            "É o escor-peão."
        ),
        new ITrocadilho(
            "Por que um determinado inseto voador não reclama de aterrissar nos piores locais possíveis?",
            "Por que Mari-pousa em qualquer lugar."
        ),
        new ITrocadilho(
            "Qual é o nome da norma jurídica para pessoas com dificuldades de dicção por repetirem demais as sílabas das palavras?",
            "Lei de Gaga."
        ),
        new ITrocadilho(
            "Tinham dez pessoas em cima de uma árvore jogando pastilhas garoto nas pessoas que passavam em baixo. Qual o nome do filme?",
            "Os Dez Manda Menta."
        ),
        new ITrocadilho(
            "Qual o ovo mais escuro que existe?",
            "Ovinho tinto."
        ),
        new ITrocadilho(
            "Por que nunca falta energia no fundo do rio?",
            "Porque ele tem enguia elétrica."
        ),
        new ITrocadilho(
            "Qual artista você não pode convidar para sua casa?",
            "O Eric... Claptomaniaco!"
        ),
        new ITrocadilho(
            "Do que as velhinhas mas sentem saudades?",
            "Da Ditadura!"
        ),
        new ITrocadilho(
            "Qual a semelhança entre o Uruguai e o YouTube?",
            "Que os dois tem um Monte-Vídeo."
        ),
        new ITrocadilho(
            "No trânsito, como fazer para as dores corporais passarem mais depressa?",
            "É só pisar no acelera-dor."
        ),
        new ITrocadilho(
            "Por que o envelope é tão medroso jogando baralho?",
            "Porque ele só guarda as cartas."
        ),
        new ITrocadilho(
            "Por que as roupas devem se pendurarem nos cabides?",
            "Porque eles não tem mãos pra segurarem elas."
        ),
        new ITrocadilho(
            "Qual a vodka que da tiros para os dois lados?",
            "Bala-lá-e-cá."
        ),
        new ITrocadilho(
            "Qual o chocolate que espanta que espanta a capital do Equador?",
            "Xô-Quito."
        ),
        new ITrocadilho(
            "Como se chama mil políticos presos?",
            "Um bom começo."
        ),
        new ITrocadilho(
            "O que desce chorando da escada?",
            "Balde."
        ),
        new ITrocadilho(
            "Por que o carro jamais é eletrocutado?",
            "Porque ele tem o para-choque."
        ),
        new ITrocadilho(
            "Qual é a versão de Dragon Ball que o Vasco, Fluminense e Botafogo mais gostam?",
            "Kai."
        ),
        new ITrocadilho(
            "Qual é o mosquito que a vaca tem medo?",
            "Muuuuriçoca."
        ),
        new ITrocadilho(
            "Por que um tigre auxiliava o idoso a andar?",
            "Porque ele era um tigre de bengala."
        ),
        new ITrocadilho(
            "Quem é que, no Natal, anda com o saco cheio às costas subindo e descendo a rua?",
            "O carteiro, ou você acredita em Papai Noel?"
        ),
        new ITrocadilho(
            "Como um escritor termina um caso de amor?",
            "Com um ponto final."
        ),
        new ITrocadilho(
            "Por que é que 'na casa do ferreiro tem espeto de pau'?",
            "Porque 'santo de casa não faz milagre'."
        ),
        new ITrocadilho(
            "Entre médicos, qual deveria ser considerado engenheiro?",
            "Os que faz pontes de safena."
        ),
        new ITrocadilho(
            "Quem é que bate na porta sem estar chamando ninguém?",
            "O marceneiro."
        ),
        new ITrocadilho(
            "Que fazem os grandes costureiros, quando não têm o que fazer?",
            "Inventam moda."
        ),
        new ITrocadilho(
            "Que pista levou o policial à certeza de que aquele carro, parado no estacionamento, era roubado?",
            "O motor estava quente, mas a placa fria."
        ),
        new ITrocadilho(
            "Qual a profissão que aborrece?",
            "A de amolador."
        ),
        new ITrocadilho(
            "Como se chama o jornal do oculista?",
            "O globo ocular."
        ),
        new ITrocadilho(
            "Qual a carta que melhora a vida do carteiro?",
            "A carta de recomendação."
        ),
        new ITrocadilho(
            "Qual o produto alimentício preferido dos escritores?",
            "A sopa de letrinhas."
        ),
        new ITrocadilho(
            "Que escritor escreve um livro em menos de um minuto?",
            "ualquer m= 'um livro'."
        ),
        new ITrocadilho(
            "Qual o lugar onde o pescador pode até escolher o peixe?",
            "Na peixaria."
        ),
        new ITrocadilho(
            "Por que um astrônomo sempre se frusta quando tenta estudar os grandes grupos de estrelas do Universo?",
            "Porque no telescópio, a visão é sempre nebulosa."
        ),
        new ITrocadilho(
            "Quem é que se encarrega pessoalmente de transmitir os nossos desabafos, as nossas alegrias, exigências e consulta sem jamais ter contato conosco?",
            "O carteiro."
        ),
        new ITrocadilho(
            "Qual é a capital preferida do Thor?",
            "PreTHORia."
        ),
        new ITrocadilho(
            "Qual a prótese que vive durante um longo período?",
            "É a denta-dura."
        ),
        new ITrocadilho(
            "Qual a haste de metal que é uma operadora de TV?",
            "É o Alfi-NET."
        ),
        new ITrocadilho(
            "Onde o Renato Aragão nasceu?",
            "Na Didi-namarca."
        ),
        new ITrocadilho(
            "Qual o país que sai pegando tudo?",
            "Catar."
        ),
        new ITrocadilho(
            "Por que a música foi na papelaria?",
            "Porque ela queria um clipe."
        ),
        new ITrocadilho(
            "No salão de beleza, por que o português colocou uma grade sobre a cabeça?",
            "Porque ele queria um de-gradê."
        ),
        new ITrocadilho(
            "Qual o jogador que trata água?",
            "Aguero."
        ),
        new ITrocadilho(
            "Qual é o jogador que não toma tiro?",
            "Dybala."
        ),
        new ITrocadilho(
            "Qual país do caribe é uma explosão?",
            "Granada."
        ),
        new ITrocadilho(
            "Nas obras, como fazer para a parede de tijolo ser recarregada?",
            "É só fazer um abaste-cimento."
        ),
        new ITrocadilho(
            "Qual o ator que os operários sobem em cima dele?",
            "Vã-Andaime."
        ),
        new ITrocadilho(
            "O que acontece se o coqueiro beber demais?",
            "Ele chapa o coco."
        ),
        new ITrocadilho(
            "Estou acima das pessoas mais posso ficar a baixo delas, sou sólido e essencial para um lar quem eu sou?",
            "Terraço."
        ),
        new ITrocadilho(
            "O que um jogador de futebol falou pro outro na hora de dar um pré-datado?",
            "Eu não tenho dinheiro, mas o Peter Cheque."
        ),
        new ITrocadilho(
            "O que a ponte pequena disse para outra que cresceu?",
            "E agora, eu te vi-adulto."
        ),
        new ITrocadilho(
            "Por que o fio sentiu frio?",
            "Porque ele estava desencapado."
        ),
        new ITrocadilho(
            "Qual é a cerveja favorita dos cachorros?",
            "Glaciau-au."
        ),
        new ITrocadilho(
            "Qual é o animal mais preguiçoso que existe?",
            "A dor-minhoca."
        ),
        new ITrocadilho(
            "Qual é o movimento que as próprias pessoas que curtem muito realizam?",
            "Fã-farra."
        ),
        new ITrocadilho(
            "Por que o energético mais conhecido do mundo agora faz propaganda de marca de informática?",
            "Porque Red Bull te dá Asus!"
        ),
        new ITrocadilho(
            "Qual é o pão que o Ursinho Pooh mais gosta?",
            "Pão de Mel."
        ),
        new ITrocadilho(
            "Qual é o brinquedo preferido do Thor?",
            "AuTHORama."
        ),
        new ITrocadilho(
            "Qual o conselho que o seu pai te dava para classificar as mulheres por tipo?",
            "Cate-gurias."
        ),
        new ITrocadilho(
            "Qual é a fruta que é também é dois animais?",
            "Jabuti-Cabra."
        ),
        new ITrocadilho(
            "Represento o amor, mas amor não posso ter, me desenham com 2 indicadores, mas como um punho da sua mão eu posso ser, que sou eu?",
            "O coração."
        ),
        new ITrocadilho(
            "O que o pobre tem que se o rico comer ele morre?",
            "Nada. O pobre tem nada, e se o rico comer nada ele morre de fome."
        ),
        new ITrocadilho(
            "Qual atriz é um peixe cartilaginoso?",
            "Claudia Arraia."
        ),
        new ITrocadilho(
            "Qual a planta dos sentimentos imediatos?",
            "Jacinto."
        ),
        new ITrocadilho(
            "O que é que diz um ratão de 100 quilos?",
            "Vem, vem gatinho."
        ),
        new ITrocadilho(
            "O que é que se pede com o dedo?",
            "Ligação telefônica."
        ),
        new ITrocadilho(
            "O que é que perdido uma vez nunca mais se acha?",
            "O tempo."
        ),
        new ITrocadilho(
            "Para que homem todos os outros tiram o chapéu?",
            "Para o barbeiro."
        ),
        new ITrocadilho(
            "Qual a palavra que você usa quando se esquece das outras?",
            "Sinônimos."
        ),
        new ITrocadilho(
            "O que nasce grande e morre pequeno?",
            "O sabão."
        ),
        new ITrocadilho(
            "O que é o que é entra na igreja de cabeça para baixo?",
            "O prego do sapato."
        ),
        new ITrocadilho(
            "Qual o jogador de basquete que trabalha como faxineiro?",
            "Anderson Varre Chão."
        ),
        new ITrocadilho(
            "Qual banda de rock que beija todo mundo?",
            "Kiss."
        ),
        new ITrocadilho(
            "Qual o cantor que se compara com as leis marítimas?",
            "Bob Mar-Lei."
        ),
        new ITrocadilho(
            "Qual o aplicativo preferido do Thor?",
            "Play sThor."
        ),
        new ITrocadilho(
            "Qual a flor que diz estar se sentindo?",
            "Jacinto."
        ),
        new ITrocadilho(
            "Qual ator é símbolo de países?",
            "Antônio Bandeiras."
        ),
        new ITrocadilho(
            "Qual o planeta mais admirado do supermercado?",
            "Uau-Marte."
        ),
        new ITrocadilho(
            "Qual a batata que todos devem respeitar?",
            "Lays."
        ),
        new ITrocadilho(
            "Qual o hipermercado preferido do número 4?",
            "Carre-Four."
        ),
        new ITrocadilho(
            "Qual a universidade particular que quase tira um dez?",
            "Uni-nove."
        ),
        new ITrocadilho(
            "Qual a diferença entre um limão e o Mr. Bean?",
            "Que o limão só faz careta quando é chupado."
        ),
        new ITrocadilho(
            "Qual a cerveja que os de menores não podem beber?",
            "Proibida."
        ),
        new ITrocadilho(
            "Qual o salgadinho que mais vai no jogo de futebol?",
            "A Torcida."
        ),
        new ITrocadilho(
            "O que um bolo com frio disse pro outro?",
            "Precisamos de cobertura."
        ),
        new ITrocadilho(
            "Por que o armário estava lotado?",
            "Porque todos queriam ver o jogo de panelas."
        ),
        new ITrocadilho(
            "Por que Bob Marley é folgado?",
            "Porque ele quer que o arrasta-fari."
        ),
        new ITrocadilho(
            "Tenho 5 maçãs, roubo de Joãozinho 5, quantas tartarugas tem no pote de doce?",
            "Duas, pois vassoura não assiste TV a noite."
        ),
        new ITrocadilho(
            "Qual animal mais gosta de cantar em grupo?",
            "A cobra-coral."
        ),
        new ITrocadilho(
            "Por que os padres amam açúcar?",
            "Porque eles abraçam um sacer-doce-o."
        ),
        new ITrocadilho(
            "Qual é a comida favorito da piranha?",
            "Pirão."
        ),
        new ITrocadilho(
            "O que uma ave perguntou pra outra sobre o futebol?",
            "Meu time é o Flamingo, e o seu?"
        ),
        new ITrocadilho(
            "Por que um dos maiores apresentadores da Rede Globo não queria uma fazenda?",
            "Porque ele queria apenas uma Chacrinha."
        ),
        new ITrocadilho(
            "Qual a doença que mais incomoda os gaúchos?",
            "Artri-tchê."
        ),
        new ITrocadilho(
            "Por que Angelina não é considerada uma atriz completa?",
            "Porque para isso, Angelina além de Jô-Li, deveria ser Jô-Escrevi também."
        ),
        new ITrocadilho(
            "Por que o ex-marido de Angelina Jolie é considerado um cara muito chato?",
            "Porque vive o Brad dando Pití."
        ),
        new ITrocadilho(
            "Qual é o veículo de comunicação que sempre obverva você?",
            "É a Rede Te Vê."
        ),
        new ITrocadilho(
            "Por que nos montes mais altos e frios da Suíça tem cachorros?",
            "Porque lá estão os au-aupes."
        ),
        new ITrocadilho(
            "Qual é o legume favorito do menino de madeira que cresce o nariz?",
            "O Pepinóquio."
        ),
        new ITrocadilho(
            "Qual a fruta que tem título de nobreza?",
            "Fruta-do-Conde."
        ),
        new ITrocadilho(
            "Por que o português colocou a cama no guarda-roupas?",
            "Por que o médico o pediu para guardar leito."
        ),
        new ITrocadilho(
            "O que o mineirinho pediu ao saber que no cardápio de um determinado restaurante só servia frutos do mar?",
            "Uma banana d'água."
        ),
        new ITrocadilho(
            "Qual é o país onde as pessoas mais praticam musculação?",
            "Só-malha."
        ),
        new ITrocadilho(
            "Qual é o animal que mais sente quando a temperatura está alta?",
            "A Calor-psita."
        ),
        new ITrocadilho(
            "Qual animal é o melhor dos dançarinos?",
            "O tatu-re-bola."
        ),
        new ITrocadilho(
            "Qual o celular que deixa você fazer o que quiser com ele?",
            "Ai pode."
        ),
        new ITrocadilho(
            "Por que a roupa saiu correndo e pulou na banheira d'água?",
            "Porque ela só levava ferro."
        ),
        new ITrocadilho(
            "Por que um homem vivia cheio de velas em sua casa?",
            "Porque ele era fã do Caetano Veloso."
        ),
        new ITrocadilho(
            "Por que a galinha gorda estava batendo a cabeça no bebedouro elétrico?",
            "Porque ela queria um galão."
        ),
        new ITrocadilho(
            "Qual é a profissão agente do Thor?",
            "CorreThor."
        ),
        new ITrocadilho(
            "O que o Thor mais gosta do banheiro?",
            "Thor-alha."
        ),
        new ITrocadilho(
            "Qual é a função de autoridade do Thor?",
            "PromoThor."
        ),
        new ITrocadilho(
            "Qual o jogador que larga as coisas de qualquer jeito?",
            "Se-dane."
        ),
        new ITrocadilho(
            "Por que a vaca foi pra Alemanha?",
            "Porque ela queria ver Muuuuu-nique."
        ),
        new ITrocadilho(
            "Por que a loira joga o relógio pela janela?",
            "Porque a hora voa."
        ),
        new ITrocadilho(
            "Por que o Médico tem a letra feia?",
            "Porque ele não sabe escrever, só prescrever."
        ),
        new ITrocadilho(
            "O que o gato faz quando está na rua?",
            "Engatinha."
        ),
        new ITrocadilho(
            "Por que os cães da Austrália ficam roucos?",
            "Porque a capital do país se chama cão-berra."
        ),
        new ITrocadilho(
            "Por que os papéis e as folhas tem medo do Rio de Janeiro?",
            "Porque eles fazem picadinho."
        ),
        new ITrocadilho(
            "Qual a ave que quer matar as vacas imediatamente em busca de seu couro?",
            "Couro-já."
        ),
        new ITrocadilho(
            "Qual é a Lua que nunca esta com fome?",
            "Lua cheia."
        ),
        new ITrocadilho(
            "O que tem cara de um lado e animal do outro?",
            "As notas."
        ),
        new ITrocadilho(
            "Segunda pessoa do singular; Água passa; Qual é o nome do animal?",
            "TUcano."
        ),
        new ITrocadilho(
            "Eu tenho um cachorro que se chama Choco. O que Choco faz?",
            "CHOCO-late."
        ),
        new ITrocadilho(
            "Ge estava andando de bicicleta, mas ele não viu a ladeira que estava à sua frente. O que falaram para ele?",
            "Ge-Ladeira."
        ),
        new ITrocadilho(
            "O que o tempo e a novela tem em comum?",
            "O tempo é o Senhor da Razão, e a novela é a Senhora do Destino."
        ),
        new ITrocadilho(
            "Por que parente e igual a dente?",
            "Porque quanto mais afastado melhor pra não juntar sujeira."
        ),
        new ITrocadilho(
            "Qual o país dos touros?",
            "Bull-Garia."
        ),
        new ITrocadilho(
            "Qual a cantora que abre todas as portas?",
            "Kelly Key."
        ),
        new ITrocadilho(
            "Por que os torcedores estavam com a mão na cara?",
            "Por que os atletas iam jogar tênis."
        ),
        new ITrocadilho(
            "Por que as abelhas não comem pão de sal?",
            "Porque elas já têm o pão de mel."
        ),
        new ITrocadilho(
            "Nas novelas, como fazer para os atores vovôs falarem mais alto?",
            "É só apertar o vô-lume."
        ),
        new ITrocadilho(
            "Por que os camaleões mudam de cor sozinho?",
            "Porque eles não precisam de lápis de cor."
        ),
        new ITrocadilho(
            "Qual a comida que tem um grupo de soldados prontos para guerra?",
            "Feijão Tropeiro."
        ),
        new ITrocadilho(
            "Por que os baianos não deixam nada aberto?",
            "Porque eles tem o vatampá."
        ),
        new ITrocadilho(
            "Qual o ator que mais gosta de flores?",
            "Tony Ramos."
        ),
        new ITrocadilho(
            "Qual a atriz mais enxuta?",
            "Deborah Secco."
        ),
        new ITrocadilho(
            "Qual o santo do Rodrigo?",
            "São Toro."
        ),
        new ITrocadilho(
            "Qual enfermidade tem o técnico da seleção brasileira de futebol quando entra em um labirinto?",
            "Labirin-Tite."
        ),
        new ITrocadilho(
            "Qual o jogador que só vive com raiva?",
            "Bravo."
        ),
        new ITrocadilho(
            "O que todo homem faz quando está no banheiro?",
            "Sai do banheiro."
        ),
        new ITrocadilho(
            "Por que o nadador jogou a televisão na piscina?",
            "Para fazer um nado sintonizado."
        ),
        new ITrocadilho(
            "Por que o italiano tem que se equilibrar jogando xadrez?",
            "Porque senão ele perde sua torre."
        ),
        new ITrocadilho(
            "Por que a cama do sabão facilmente estoura?",
            "Porque seu colchão é de espuma."
        ),
        new ITrocadilho(
            "Qual é o eletrodoméstico preferido do Batman?",
            "Bat-deira."
        ),
        new ITrocadilho(
            "Qual comida que quase tira um 10?",
            "Strogo-nove."
        ),
        new ITrocadilho(
            "Qual o brinquedo preferido do McDonald's?",
            "McSteel."
        ),
        new ITrocadilho(
            "O que a vaca foi fazer na papelaria?",
            "Comprar uma muuuuuuuu-chila."
        ),
        new ITrocadilho(
            "Qual o material escolar que mostra a parte de seu corpo que dói?",
            "Aponta-dor."
        ),
        new ITrocadilho(
            "Qual a rede social mais gorda?",
            "InstaGrama."
        ),
        new ITrocadilho(
            "Qual é o tipo de festa que os cegos frequentam?",
            "O braille funk."
        ),
        new ITrocadilho(
            "Por que no Rio de Janeiro as pessoas não comem pão de sal?",
            "Porque eles têm o Pão de Açúcar."
        ),
        new ITrocadilho(
            "Qual super herói tira foto no escuro?",
            "Flash."
        ),
        new ITrocadilho(
            "Quando está apaixonado, como um sabão em pó se declara?",
            "Eu te OMO."
        ),
        new ITrocadilho(
            "O que a mãe açaí disse para os outros açaís?",
            "O último açaí feche a porta."
        ),
        new ITrocadilho(
            "Qual é o carro que gosta de fazer exercícios?",
            "Cooper."
        ),
        new ITrocadilho(
            "Por que o pai do Thor é um ser pré-histórico?",
            "Porque ele é Odinossauro."
        ),
        new ITrocadilho(
            "O que o Batman faz com o celular?",
            "Bat-Selfie."
        ),
        new ITrocadilho(
            "Qual o contrário de futsal?",
            "Fut-açúcar."
        ),
        new ITrocadilho(
            "Como seria o nome chinês do preguiçoso?",
            "Kan-sei ou kochi-lin."
        ),
        new ITrocadilho(
            "Por que o relógio é popular?",
            "Porque ele é da hora."
        ),
        new ITrocadilho(
            "Por que a piada da bola é a melhor?",
            "Porque ela é bem bolada."
        ),
        new ITrocadilho(
            "Qual é o traficante que toma uma gelada no boteco?",
            "Pablo Skol Bar."
        ),
        new ITrocadilho(
            "O que tem 5 cordas e uma cova?",
            "Violão."
        ),
        new ITrocadilho(
            "Qual o santo da Ivete?",
            "São Galo."
        ),
        new ITrocadilho(
            "Qual é o chocolate dos gatos?",
            "Kit-Cat."
        ),
        new ITrocadilho(
            "Qual o esporte preferido dos gaúchos?",
            "Basquetchê."
        ),
        new ITrocadilho(
            "Quem é o rei da farmácia?",
            "Rei-médio."
        ),
        new ITrocadilho(
            "Qual o contrário de buscapé",
            "Levamão."
        ),
        new ITrocadilho(
            "Qual o carro mais amado da Julieta?",
            "Alfa-Romeu."
        ),
        new ITrocadilho(
            "Qual a cerveja preferida dos mineiros?",
            "Bud-Uai-Zé."
        ),
        new ITrocadilho(
            "Por que a Holanda não cresce?",
            "Porque ela é um País-Baixo."
        ),
        new ITrocadilho(
            "Qual o contrário de cachorro-quente?",
            "Cadela fria."
        ),
        new ITrocadilho(
            "Por que o frango atravessou a rua?",
            "Porque era dia de folga da galinha."
        ),
        new ITrocadilho(
            "Por que o Thor é rico?",
            "Porque ele tem O-din-din."
        ),
        new ITrocadilho(
            "O que é o quê é e branco não é líquido e serve pra bebê?",
            "Fralda."
        ),
        new ITrocadilho(
            "Qual é o veículo que lava roupas?",
            "Tanque."
        ),
        new ITrocadilho(
            "Qual é a área de ensinamentos do Thor?",
            "Or-THOR-grafia."
        ),
        new ITrocadilho(
            "O que o Thor mais gosta de contar?",
            "His-THOR-ia."
        ),
        new ITrocadilho(
            "Qual é o veículo mais sacana?",
            "Velo-troll."
        ),
        new ITrocadilho(
            "O que é um grande prédio com apenas uma janela?",
            "Agulha."
        ),
        new ITrocadilho(
            "O que é que é que no interior é uma linda praia e fora um mato?",
            "Coco."
        ),
        new ITrocadilho(
            "Qual é a parte mais feminina da casa?",
            "JanELA."
        ),
        new ITrocadilho(
            "Por que o Batman é tão ruim nos jogos de carta?",
            "Porque ele só pega coringa."
        ),
        new ITrocadilho(
            "Qual é o contrário de contramão?",
            "Favorpé."
        ),
        new ITrocadilho(
            "Qual é o barco que sempre está aceso no escuro?",
            "Barco a vela."
        ),
        new ITrocadilho(
            "Qual o contrário de papelada?",
            "Pá vestida."
        ),
        new ITrocadilho(
            "Qual a ave que é marca de bicicleta?",
            "Caloi-picita."
        ),
        new ITrocadilho(
            "Qual é o alimento mais sagrado do mundo?",
            "Amén-doim."
        ),
        new ITrocadilho(
            "Como o Thor se comunica com os outros Vingadores?",
            "Por Thor-pedo."
        ),
        new ITrocadilho(
            "Qual a parte mais sonora do corpo?",
            "Rádio."
        ),
        new ITrocadilho(
            "Qual e o esporte mais salgado?",
            "Fut-sal."
        ),
        new ITrocadilho(
            "Por que o vaso é o melhor presente para se ganhar?",
            "Porque ele é de-coração!"
        ),
        new ITrocadilho(
            "O que o coelho disse quando se assustou?",
            "Ah, minha nossa cenoura!"
        ),
        new ITrocadilho(
            "Qual é o hidrocarboneto da raiva?",
            "Bicarbonato de ódio."
        ),
        new ITrocadilho(
            "Por que o macaco tem medo de martelo?",
            "Porque ele é um macaco-prego."
        ),
        new ITrocadilho(
            "Por que o jogador não estava conseguindo ligar do campo?",
            "Porque ele estava fora de área."
        ),
        new ITrocadilho(
            "Qual o maior órgão público de uma cidade?",
            "Orelhão."
        ),
        new ITrocadilho(
            "O que o astronauta foi fazer no teclado?",
            "Andar no espaço."
        ),
        new ITrocadilho(
            "Quais são os bandidos mais horríveis que existem?",
            "Os ma-feiosos."
        ),
        new ITrocadilho(
            "Qual carro está sempre ligado?",
            "On-ix."
        ),
        new ITrocadilho(
            "Por que um caminhoneiro nunca consegue pegar uma garota no deserto?",
            "Porque é muita areia pro seu caminhão."
        ),
        new ITrocadilho(
            "Por que a chuva sempre cai sem nos avisar?",
            "Porque ela é precipitada."
        ),
        new ITrocadilho(
            "O que é o que é que depois de ficar muito tempo na geladeira continua quente?",
            "Pimenta."
        ),
        new ITrocadilho(
            "João tinha nove carrinhos, emprestou quatro para o Arthur. Com quantos carrinhos João ficou?",
            "Continuou com nove, pois ele emprestou, ele não deu."
        ),
        new ITrocadilho(
            "O que é o que quando bate na pedra não quebra e quando cai na água se parte?",
            "O papel."
        ),
        new ITrocadilho(
            "Qual é o tipo de bebida preferida dos animais?",
            "As de garrafa PET."
        ),
        new ITrocadilho(
            "Qual é o prato preferido dos mecânicos?",
            "Macarrão parafuso."
        ),
        new ITrocadilho(
            "Qual é a prisão, onde todos nós estamos condenados a passar?",
            "Prisão de ventre."
        ),
        new ITrocadilho(
            "Um homem lá vinha com uma carroça, e na carroça tinha um burro, um capim e uma onça. A ponte estava quase quebrando, e ele tinha que atravessar uma coisa de cada vez, e sem deixar um comer ao outro. Que processo ele iria fazer?",
            "Ele leva o burro e deixa ele lá, volta e busca a onça, traz o burro de volta e leva o capim, depois leva o burro de novo."
        ),
        new ITrocadilho(
            "Qual é a fruta preferida do Thor?",
            "THORanja."
        ),
        new ITrocadilho(
            "Qual é o animal de estimação do Thor?",
            "THOR-upeira."
        ),
        new ITrocadilho(
            "Qual é a comida mais devagar?",
            "A po-lenta."
        ),
        new ITrocadilho(
            "Por que a menina doente foi pra a academia?",
            "Pra ficar sarada."
        ),
        new ITrocadilho(
            "Com qual gênero a matemática combina?",
            "Mulheres, pois são difíceis."
        ),
        new ITrocadilho(
            "O que o milho disse para a pipoca?",
            "HuMILHO mesmo."
        ),
        new ITrocadilho(
            "Qual é o doce preferido do Thor?",
            "Thorrone."
        ),
        new ITrocadilho(
            "Qual é o prato preferido do Thor?",
            "Thorresmo."
        ),
        new ITrocadilho(
            "O que o Thor faz quando corta o dedo?",
            "Thorniquete."
        ),
        new ITrocadilho(
            "O que acontece se o Thor assoprar?",
            "THORnado."
        ),
        new ITrocadilho(
            "Quantas pata tem uma pata?",
            "Somente uma, se fosse mais seria patapatapatapata..."
        ),
        new ITrocadilho(
            "Qual é a semelhança entre aranha e escorpião?",
            "Com nenhum dos dois dá pra fazer bolo de abacate."
        ),
        new ITrocadilho(
            "Meu avô tem 4 filhos, cada filho tem 4 filhos. Quantos primos eu tenho?",
            "12. Três são meus irmãos e um sou eu."
        ),
        new ITrocadilho(
            "Ela tinha 4 filhos. Janeiro, Fevereiro, Março. Qual é o nome do quarto filho.",
            "O nome da criança e 'Qual'."
        ),
        new ITrocadilho(
            "Qual o esporte que os cientistas gostam?",
            "Fórmula 1."
        ),
        new ITrocadilho(
            "Qual a profissão histórica do Thor?",
            "His-THOR-iógrafo."
        ),
        new ITrocadilho(
            "Qual a catástrofe que o Thor tem medo?",
            "TerremoTHOR."
        ),
        new ITrocadilho(
            "O que o gato faz quando está na rua?",
            "Engata."
        ),
        new ITrocadilho(
            "Qual é a profissão do Thor?",
            "Mo-THOR-ista."
        ),
        new ITrocadilho(
            "Qual a especialização do Thor?",
            "PaTHORlogia."
        ),
        new ITrocadilho(
            "Qual a profissão secreta do Thor?",
            "InspeThor."
        ),
        new ITrocadilho(
            "Qual é o frango que está sempre na mesa?",
            "O frango alinamesa."
        ),
        new ITrocadilho(
            "Qual é a profissão do Thor?",
            "Thoreiro."
        ),
        new ITrocadilho(
            "Qual o pão que o Thor mais come?",
            "O THORrado."
        ),
        new ITrocadilho(
            "No carro estavam 1 avó, 2 pais, 2 filhos e 1 neto. Quantas pessoas estavam no carro?",
            "3 pessoas."
        ),
        new ITrocadilho(
            "O que é surdo e mudo mas conta tudo?",
            "Livro."
        ),
        new ITrocadilho(
            "Por que a fração não cabe em uma casa?",
            "Por que ela tem 4 quarto."
        ),
        new ITrocadilho(
            "Qual a parte do corpo que Thor mais gosta?",
            "Thornozelo."
        ),
        new ITrocadilho(
            "O que o zero disse para o seis?",
            "Nossa, apertou tanto o cinto que abriu a boca."
        ),
        new ITrocadilho(
            "Qual e o animal que mais gosta de jogar futebol?",
            "GOLfinho."
        ),
        new ITrocadilho(
            "Qual é o carro que só anda bem vestido?",
            "Blazer."
        ),
        new ITrocadilho(
            "Por que guarda de trânsito é o ser mais forte do mundo?",
            "Porque ele pode parar carros só com uma das mãos."
        ),
        new ITrocadilho(
            "Qual é o fenômeno que acontece no mar que o Thor tem medo?",
            "Thormenta."
        ),
        new ITrocadilho(
            "Qual é o animal que mais gosta de jogar futebol?",
            "O goooooooooolfinho."
        ),
        new ITrocadilho(
            "Tinha um pontinho verde no Xbox, qual é o nome do jogo?",
            "Assassins GreenD."
        ),
        new ITrocadilho(
            "Por que não podemos levar cães pros Estados Unidos?",
            "Porque lá fura-cão."
        ),
        new ITrocadilho(
            "Qual é o país feminino?",
            "VenezuELA."
        ),
        new ITrocadilho(
            "Qual a meditação que se faz acordado?",
            "ONnnn..."
        ),
        new ITrocadilho(
            "O que a legume é do filho do filho dela?",
            "Avóbora."
        ),
        new ITrocadilho(
            "O que o zero dise para o oito?",
            "Nossa, que cinto apertado!"
        ),
        new ITrocadilho(
            "O que passa por todas as casas mas não sai do lugar?",
            "A rua."
        ),
        new ITrocadilho(
            "Cinco políticos estavam em uma lancha que acabou virando no meio do mar. Você sabe como salvá-los?",
            "Não? Perfeito!"
        ),
        new ITrocadilho(
            "Qual é o bicho que anda com as patas?",
            "O pato."
        ),
        new ITrocadilho(
            "O que o Thor gosta de ser no tempo livre?",
            "Fo-THOR-grafo."
        ),
        new ITrocadilho(
            "Por que as mulheres não sentem frio?",
            "Porque elas estão cobertas de razão."
        ),
        new ITrocadilho(
            "Por que em Minas Gerais não tem mar?",
            "Porque lá eles rezam livrai-nos de todos os mar."
        ),
        new ITrocadilho(
            "Qual o animal que a gordinha não quer encontrar de jeito nenhum quando fica magra?",
            "O ex-quilo."
        ),
        new ITrocadilho(
            "Quem é a mãe da cozinha?",
            "A mãezena."
        ),
        new ITrocadilho(
            "O que o Thor usa nos pés para não se machucar enquanto corre?",
            "Thor-nozeleiras."
        ),
        new ITrocadilho(
            "Qual o doce favorito do Thor?",
            "Thortuguita."
        ),
        new ITrocadilho(
            "Do que o Thor faz parte?",
            "Da Thorcida."
        ),
        new ITrocadilho(
            "O que Michael Phelps disse para Sócrates?",
            "Só sei que nadar sei."
        ),
        new ITrocadilho(
            "O que o Batman mais sente no peito?",
            "Bat-mentos."
        ),
        new ITrocadilho(
            "Por que  o filho do joalheiro estuda tanto?",
            "Pra ser um adulto joia."
        ),
        new ITrocadilho(
            "Por que o surfista não gosta da cozinha?",
            "Porque lá só tem micro-ondas."
        ),
        new ITrocadilho(
            "Qual é o time preferido do Thor?",
            "Thorino."
        ),
        new ITrocadilho(
            "Qual é a cidade preferida do Thor?",
            "Thoronto."
        ),
        new ITrocadilho(
            "Qual é a parte do quarto que o Thor mais gosta?",
            "Thormada."
        ),
        new ITrocadilho(
            "O que acontece se colocarmos sal em um boi bem pequeno?",
            "Vira um sal-gadinho."
        ),
        new ITrocadilho(
            "O que até o mais pobre de todos tem?",
            "Nome."
        ),
        new ITrocadilho(
            "Quantas sílaba tem a palavra Trissílaba?",
            "Uma, se fosse mais seria Trissílabasílabasílaba..."
        ),
        new ITrocadilho(
            "O que para ser direito tem que ser torto?",
            "Anzol."
        ),
        new ITrocadilho(
            "Qual o remédio que contém álcool e gasolina?",
            "Dorflex."
        ),
        new ITrocadilho(
            "Qual é o animal favorito dos pintores?",
            "Onça pintada."
        ),
        new ITrocadilho(
            "Qual a especialidade de Thor?",
            "OrTHORpedista."
        ),
        new ITrocadilho(
            "Qual o tênis quer ser uma majestade?",
            "Rainha."
        ),
        new ITrocadilho(
            "Qual é o corte de cabelo preferido do Thor?",
            "THORpete."
        ),
        new ITrocadilho(
            "Qual a semelhança de um sapo e uma vassoura?",
            "Com nenhum dos dois dá pra fazer pastel."
        ),
        new ITrocadilho(
            "Qual a Profissão preferida do Thor?",
            "THORpógrafo."
        ),
        new ITrocadilho(
            "Qual é a luta dos Gaúchos?",
            "KaraTCHÊ."
        ),
        new ITrocadilho(
            "Qual é o carro movido a suco?",
            "MusTANG"
        ),
        new ITrocadilho(
            "Qual é a roupa preferido do macaco?",
            "Macacão."
        ),
        new ITrocadilho(
            "Qual é o fenômeno da Natureza que o Thor tem medo?",
            "Thornado."
        ),
        new ITrocadilho(
            "Qual a cidade do Thor?",
            "Thórquio."
        ),
        new ITrocadilho(
            "Tenho 40 laranjas, tiro 20. Quantas laranjas eu tenho?",
            "Eu sabia isso com maçãs."
        ),
        new ITrocadilho(
            "Qual a cantora que mais gosta de rir?",
            "Ri-hanna."
        ),
        new ITrocadilho(
            "Qual a parte do corpo do Thor que ele mais gosta?",
            "THORax."
        ),
        new ITrocadilho(
            "Qual a cantora gosta muito de tomar chá?",
            "Chá-quira."
        ),
        new ITrocadilho(
            "Tenho cinco laranjas, João roubou três. Quantas laranjas eu tenho?",
            "Cinco."
        ),
        new ITrocadilho(
            "Qual é a semelhança de uma dentadura e um chifre?",
            "Ambos machucam mas acostumam."
        ),
        new ITrocadilho(
            "Qual é o fruto preferido do Thor?",
            "Thormate."
        ),
        new ITrocadilho(
            "Qual é a atriz preferida do tamanduá?",
            "Vera Farmiga"
        ),
        new ITrocadilho(
            "Qual o time o Thor torce?",
            "Thorttenham."
        ),
        new ITrocadilho(
            "Quando foi a primeira vez que os povos da América comeram carne?",
            "Quando chegou Cristóvão Com-lombo."
        ),
        new ITrocadilho(
            "Qual é o carro está sempre chateado?",
            "Bravo."
        ),
        new ITrocadilho(
            "Por que na floresta tem sal?",
            "Porque ela é temperada."
        ),
        new ITrocadilho(
            "O que o Mickey foi fazer no espaço?",
            "Procurar o pai do seu cachorro, o Plutão."
        ),
        new ITrocadilho(
            "Por que a loira tomou o remédio antes da hora certa?",
            "Pra pegar a doença de surpresa!"
        ),
        new ITrocadilho(
            "Qual é a parte do banheiro que o Thor mais gosta?",
            "Da Thorneira."
        ),
        new ITrocadilho(
            "Qual é a cidade preferida do tamanduá?",
            "Formiga."
        ),
        new ITrocadilho(
            "Qual é o país preferido no Natal?",
            "Peru."
        ),
        new ITrocadilho(
            "Qual é a tinta que quer ser uma cobra?",
            "Coral."
        ),
        new ITrocadilho(
            "Qual é a cidade preferida do Thor?",
            "Thórquio."
        ),
        new ITrocadilho(
            "O que o pastel falou para o outro pastel?",
            "Estamos fritos."
        ),
        new ITrocadilho(
            "Hoje não tenho valor, mas já vali muito. O que sou?",
            "História."
        ),
        new ITrocadilho(
            "O que nasce uma vez, nasce duas vezes, mas na terceira não nasce mais?",
            "Dente."
        ),
        new ITrocadilho(
            "Em qual estado brasileiro as pessoas mais gostam de tomar suco?",
            "Rio Grande do Suco."
        ),
        new ITrocadilho(
            "O que o aluno fala para a professora e gosta de receber dos pais?",
            "Presente."
        ),
        new ITrocadilho(
            "O que acontece se um ciclista entrar em campo?",
            "Ele faz um gol de bicicleta."
        ),
        new ITrocadilho(
            "Qual é o estado preferido do Thor?",
            "THORcantins."
        ),
        new ITrocadilho(
            "Nunca para frente, sempre para trás, para crianças sou muito devagar, para adultos fui rápido demais. O que sou?",
            "Infância."
        ),
        new ITrocadilho(
            "Nos vire ao avesso, e abra nossas vísceras, você será o mais sábio dos homens, mas, sem nós, será um idiota. O que sou?",
            "Livro."
        ),
        new ITrocadilho(
            "De mim, surge vida, para mim, a vida retorna. Homens brigam pela minha posse, mas nenhum deles é meu dono. Água me cerca, mas ao redor dela eu vivo. Quem sou eu, meu amigo?",
            "Terra."
        ),
        new ITrocadilho(
            "Assisti ao nascimento de reis e rainhas, meus pés vão mais fundo e minha cabeça mais alto do que tudo que o homem cria. Muitos buscam algo no interior do meu coração, mas, amor, não é algo que encontrarão, como vocês me chamarão?",
            "Montanha."
        ),
        new ITrocadilho(
            "Por que os robôs nao sentem medo?",
            "Porque eles têm nervos de aço."
        ),
        new ITrocadilho(
            "Qual é estado que gosta de cavar buracos?",
            "Ama-pá."
        )
    };
        public static ITrocadilho getTrocadilho()
        {
            var indexAleatorio = new Random().Next(0, data.Count - 1);
            return data.ElementAt(indexAleatorio);
        }
    }
}
