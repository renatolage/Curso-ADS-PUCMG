import { Layout, Input, Message } from "components";
import { useState } from "react";
import { useProdutoService } from "app/services";
import { Produto } from "app/models/produtos";
import { converterEmBigDecimal } from "app/utils/money";
import { Alert } from "components/commons/message";
import * as yup from 'yup'

const campoObrigatorio = "Este campo é obrigatório."

const validationSchema = yup.object().shape({
    sku: yup.string().trim().required(campoObrigatorio),
    nome: yup.string().trim().required(campoObrigatorio),
    preco: yup.number().required(campoObrigatorio).moreThan(0, "O preço deve ser maior que R$0,00."),
    descricao: yup.string().trim().required(campoObrigatorio)
})

interface FormErros {
    sku?: string;
    nome?: string;
    preco?: string;
    descricao?: string;
}

export const CadastroProdutos: React.FC = () => {

    const service = useProdutoService()
    const [ sku, setSku ] = useState<string>('')
    const [ preco, setPreco ] = useState<string>('')
    const [ nome, setNome ] = useState<string>('')
    const [ descricao, setDescricao ] = useState<string>('')
    const [id, setId ] = useState<number>() 
    const [ cadastro, setCadastro ] = useState<string>()
    const [ messages, setMessages ] = useState<Array<Alert>>([])
    const [ errors, setErrors ] = useState<FormErros>({})


    const submit = () => {
        const produto: Produto = {
            id,
            sku,
            preco: converterEmBigDecimal(preco),
            nome,
            descricao
        }

        validationSchema.validate(produto).then(obj => {
            setErrors({})
            if(id) {
                service.atualizar(produto)
                .then(response => {
                    setMessages([{tipo: "success", texto: "Produto atualizado com sucesso!" }])
                })
            } else {
            
                service.salvar(produto).then(produtoResposta => {
                    setId(produtoResposta.id)
                    setCadastro(produtoResposta.cadastro)
                    setMessages([{tipo: "success", texto: "Produto criado com sucesso!" }])
                })
            }
        }).catch(err =>{
            const field  = err.path;
            const message = err.message;

            setErrors({
                [field]: message
            })
        })




    }

    return(
        <Layout titulo="Cadastro de Produtos" mensagens={messages}>
            {id &&
                <div className="columns">
                    <Input 
                        label="Código:"
                        columnClasses="is-half"
                        value={id}
                        id="inputId"
                        disabled={true}
                    />
                    <Input 
                        label="Data de Cadastro"
                        columnClasses="is-half"
                        value={cadastro}
                        id="inputDataCadastro"
                        disabled={true}
                    />
                </div>
            }

            <div className="columns">
                <Input 
                    label="SKU: *"
                    columnClasses="is-half"
                    onChange={setSku}
                    value={sku}
                    id="inputSKU"
                    placeholder="Inseira o SKU do produto"
                    error={errors.sku}
                />
                <Input 
                    label="Preco: *"
                    columnClasses="is-half"
                    onChange={setPreco}
                    value={preco}
                    id="inputPreco"
                    placeholder="Insira o preço do produto"
                    currency={true}
                    maxLength={6}
                    error={errors.preco}
                />
            </div>
            <div className="columns">

                <Input 
                    label="Nome: *"
                    columnClasses="is-full"
                    onChange={setNome}
                    value={nome}
                    id="inputNome"
                    placeholder="Inseira o nome do produto"
                    error={errors.nome}
                />
                
            </div>
            <div className="field">
                <label className="label" htmlFor="inputDesc">Descrição: *</label>
                <div className="control">
                    <textarea className="textarea" 
                                    placeholder="Digite a descrição do produto"
                                    value={descricao}
                                    onChange={ event => setDescricao(event.target.value) }
                                    id="inputDesc" />
                    {errors.descricao &&
                        <p className="help is-danger">{errors.descricao}</p>
                    }
                </div>
            </div>

            <div className="field is-grouped">
                <div className="control">
                    <button onClick={ submit } className="button is-link">
                        {id ? "Atualizar" : "Salvar"}
                    </button>
                </div>
                <div className="control">
                    <button className="button">Voltar</button>
                </div>
            </div>
            
        </Layout>
    )
}