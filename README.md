# Dhauz-Movies

# Documentação da API

Esta é a documentação da API Dhauz-Movies.

## Endpoints

Aqui estão alguns dos endpoints disponíveis nesta API:

### `POST /movies/register`

Descrição: Endpoint para registro do filme na base vinculando o id do IMDb.

#### Corpo da Solicitação

O corpo da solicitação deve ser um objeto JSON com as seguintes propriedades:

- `imDbId` (string): O identificador IMDb do filme.
- `name` (string): O nome do filme.
- `description` (string): Uma breve descrição do filme.
- `releaseDate` (string): A data de lançamento do filme no formato "AAAA-MM-DDTHH:mm:ss.fffZ".
- `genre` (string): O gênero do filme.
- `userScore` (string): A nota do usuário para o filme.
- `watched` (boolean): Indica se o filme já foi assistido (true para assistido, false caso contrário).

Exemplo do corpo da solicitação:

```json
{
    "imDbId": "tt11737520",
    "name": "One Piece",
    "description": "Em um mundo marítimo, um jovem capitão pirata parte com sua equipe para alcançar o título de Rei dos Piratas e descobrir o tesouro mítico One Piece.",
    "releaseDate": "2023-09-14T20:36:02.892Z",
    "genre": "Ação"
}

#### Exemplo de Uso

bash
curl -X 'POST' \
  'https://localhost:7044/movies/register' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
    "imDbId": "tt11737520",
    "name": "One Piece",
    "description": "Em um mundo marítimo, um jovem capitão pirata parte com sua equipe para alcançar o título de Rei dos Piratas e descobrir o tesouro mítico One Piece.",
    "releaseDate": "2023-09-14T20:36:02.892Z",
    "genre": "Ação"
}'