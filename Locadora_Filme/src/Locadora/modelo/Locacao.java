package Locadora.modelo;

import java.sql.Date;
import java.util.Objects;

public class Locacao {
    Integer id_loc,id_filme1_pk,id_filme2_pk,id_filme3_pk,id_filme4_pk,id_cliente_pk;
    String titulo,nome,cpf,status,data_loc,data_dev;
    Double valor;
public Locacao(){
    
}
    @Override
    public int hashCode() {
        int hash = 7;
        hash = 37 * hash + Objects.hashCode(this.id_loc);
        hash = 37 * hash + Objects.hashCode(this.id_filme1_pk);
        hash = 37 * hash + Objects.hashCode(this.id_cliente_pk);

        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Locacao other = (Locacao) obj;
        if (!Objects.equals(this.id_loc, other.id_loc)) {
            return false;
        }
        if (!Objects.equals(this.id_filme1_pk, other.id_filme1_pk)) {
            return false;
        }
        if (!Objects.equals(this.id_cliente_pk, other.id_cliente_pk)) {
            return false;
        }
   
        return true;
    }

    public String getData_loc() {
        return data_loc;
    }

    public void setData_loc(String data_loc) {
        this.data_loc = data_loc;
    }

    public String getData_dev() {
        return data_dev;
    }

    public void setData_dev(String data_dev) {
        this.data_dev = data_dev;
    }

    public Integer getId_filme1_pk() {
        return id_filme1_pk;
    }

    public void setId_filme1_pk(Integer id_filme1_pk) {
        this.id_filme1_pk = id_filme1_pk;
    }

    public Integer getId_filme2_pk() {
        return id_filme2_pk;
    }

    public void setId_filme2_pk(Integer id_filme2_pk) {
        this.id_filme2_pk = id_filme2_pk;
    }

    public Integer getId_filme3_pk() {
        return id_filme3_pk;
    }

    public void setId_filme3_pk(Integer id_filme3_pk) {
        this.id_filme3_pk = id_filme3_pk;
    }

    public Integer getId_filme4_pk() {
        return id_filme4_pk;
    }

    public void setId_filme4_pk(Integer id_filme4_pk) {
        this.id_filme4_pk = id_filme4_pk;
    }

    public Double getValor() {
        return valor;
    }

    public void setValor(Double valor) {
        this.valor = valor;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public Integer getId_loc() {
        return id_loc;
    }

    public void setId_loc(Integer id_loc) {
        this.id_loc = id_loc;
    }

    public Integer getId_filme_pk() {
        return id_filme1_pk;
    }

    public void setId_filme_pk(Integer id_filme_pk) {
        this.id_filme1_pk = id_filme_pk;
    }

    public Integer getId_cliente_pk() {
        return id_cliente_pk;
    }

    public void setId_cliente_pk(Integer id_cliente_pk) {
        this.id_cliente_pk = id_cliente_pk;
    }

   
    
}
