document.addEventListener("click", function(issrc)

                    {

                    if (issrc.target.id =="click_img1")

                    {

                        if(blockImg1.style.display == "block")

                        {

                        blockImg1.style.display = "none";

                        }

                        else

                        {

                        blockImg1.style.display = "block";

                        }

                    }

                    if (issrc.target.className =="click_img1")

                    {

                        click_img1.src = document.querySelector("#"+issrc.target.id).src;

                        blockImg1.style.display = "none";

                    }

                    });
