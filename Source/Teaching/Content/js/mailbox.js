       function cheackbook() {
           var form = document.form_book;
           if (form.book_title.value.replace(/ /g, "") == "") {
               alert("留言标题内容不能为空，请认真填写");
               form.book_title.focus();
               return false;
           }

           if (form.book_name.value.replace(/ /g, "") == "") {
               alert("留言者姓名不能为空，请重新填写");
               form.book_name.focus();
               return false;
           }
           else if (form.book_name.value.replace(/ /g, "").length < 2) {
               alert("姓名字数太短了，请填写真实姓名");
               form.book_name.focus();
               return false;
           }
           else if (form.book_name.value.replace(/ /g, "").length > 10) {
               alert("姓名字数太长了，请填写真实姓名");
               form.book_name.focus();
               return false;
           }
           if (form.book_email.value.replace(/ /g, "") == "") {
               alert("电子邮件地址不能为空");
               form.book_email.focus();
               return false;
           }
           if (form.book_email.value.replace(/ /g, "") != "") {
               if ((!/^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/.test(form.book_email.value.replace(/ /g, "")))) {
                   alert("电子邮件格式不符合标准");
                   form.book_email.focus();
                   return false;
               }
           }
           if (form.book_qq.value.replace(/ /g, "") == "") {
               alert("联系QQ不能为空");
               form.book_qq.focus();
               return false;
           }
           if (isNaN(form.book_qq.value)) {
               alert("QQ号码必须为数字");
               form.book_qq.focus();
               return false;
           }
           if (form.book_qq.value.replace(/ /g, "").length != "" & form.book_qq.value.replace(/ /g, "").length < 5) {
               alert("QQ号码不符合标准");
               form.book_qq.focus();
               return false;
           }
           if (form.book_qq.value.replace(/ /g, "").length > 12) {
               alert("这么长的QQ号码不符合标准");
               form.book_qq.focus();
               return false;
           }
           if (form.book_body.value.replace(/ /g, "") == "") {
               alert("留言内容不能为空");
               form.book_body.focus();
               return false;
           }
           else if (form.book_body.value.replace(/ /g, "").length < 8) {
               alert("留言内容太少了，有刷屏的嫌疑!\n\n呵呵，请重新输入你的留言。");
               form.book_body.focus();
               return false;
           }

       }
