var sliderIMG = (function () {
    function getElementsByClass(object, tag, className) {
        var o = object.getElementsByTagName(tag);
        for (var i = 0, n = o.length, ret = []; i < n; i++)
            if (o[i].className == className) ret.push(o[i]);
        if (ret.length == 1) ret = ret[0];
        return ret;
    }

    function MouseXY(e) {
        if (window.event) {
            return { x: window.event.offsetX, y: window.event.offsetY };
        } else {
            return { x: e.layerX, y: e.layerY };
        }
    }

    function addEvent(elem, type, handle) {
        if (window.addEventListener) {
            elem.addEventListener(type, handle, false);
        } else if (window.attachEvent) {
            elem.attachEvent('on' + type, handle);
        } else {
            elem['on' + type] = handle;
        }
    }

    function _property(obj) {
        var o = {};
        for (var pro in obj) {
            o[pro] = obj[pro];
        }
        return o;
    }

    function imageFlow(id, properties) {
        this.DIV = document.getElementById(id);
        this.DIVpros = _property(properties);
        this.init = function () {
            this.bank = getElementsByClass(this.DIV, 'div', 'bank');
            this.face = getElementsByClass(this.DIV, 'div', 'mainOpacity');
            this.current = getElementsByClass(this.DIV, 'span', 'currentScroll');
            this.count = this.DIVpros.count;
            this.spanWidth = this.bank.offsetWidth / this.count;
            this.current.style.width = this.spanWidth + 'px';
            this.current.innerHTML = 1;
            this.scrollBar = this.current.parentNode;
            this.index = 0;
            if (this.index == 0) {
                this.current.style.left = 0 + 'px';
            }
            this.timer = this.DIVpros.timer || 5000;
            this.time = this.DIVpros.time || 10;
            this.speed = this.DIVpros.speed || 5;
            this.target = 0;
            this.auto = this.DIVpros.auto || false;
            this.check = true;
            this.che = false;
            clearInterval(this.doRoll);
            clearInterval(this.checkedRoll);
            clearTimeout(this.autoed);
        }

        this.start = function (e) {
            this.init();
            var self = this;
            addEvent(self.face, 'click', function (e) {
                var mouse = MouseXY(e);
                var x = mouse.x;
                var y = mouse.y;
                if (self.check) {
                    self.check = false;
                    self.roll(x, y, e);
                }
            });
            addEvent(self.scrollBar, 'click', function (e) {
                var mouse = MouseXY(e);
                var x = mouse.x;
                if (self.check) {
                    self.check = false;
                    self.checkRoll(x, e);
                }
                clearTimeout(this.autoed);
                self.che == false
                if (self.auto == false) return;
                if (self.auto && self.che == false) {
                    clearTimeout(this.autoed);
                    clearInterval(this.checkedRoll);
                    clearInterval(this.doRoll);
                    self.autoed = setTimeout(function (e) {
                        self.autoScroll(e);
                    }, self.timer);
                }
            });

            if (self.auto == true) {
                addEvent(self.face, 'mouseover', function () {
                    self.auto = false;
                    self.autoScroll(e);
                });
                addEvent(self.face, 'mouseout', function () {
                    self.auto = true;
                    self.autoed = setTimeout(function (e) {
                        self.autoScroll(e);
                    }, self.timer);
                });

                self.autoed = setTimeout(function (e) {
                    if (self.check) {
                        self.check = false;
                        self.autoScroll(e);
                    }
                }, self.timer);
            }
        }

        this.autoScroll = function (e) {
            clearTimeout(this.autoed);
            var self = this;
            if (self.auto == true) {
                var left = parseInt(self.current.style.left);
                var x = left + self.spanWidth;
                if (left == self.bank.offsetWidth - self.spanWidth) {
                    x = 0;
                }
                self.checkRoll(x, e);
                self.autoed = setTimeout(function () {
                    self.autoScroll(e);
                }, self.timer);
            }
        }

        this.setOpacity = function () {

        }

        this.roll = function (x, y, e) {
            clearTimeout(this.autoed);
            clearInterval(this.checkedRoll);
            clearInterval(this.doRoll);
            var w = this.bank.offsetWidth;
            var h = this.bank.offsetHeight;
            var self = this;
            if (y >= 0 && y <= h) {
                var step = [];
                var target = [];
                if (x > 0 && x < w / 2) {
                    var t1 = self.bank.scrollLeft + w / 2;
                    self.index++;
                } else {
                    var t1 = self.bank.scrollLeft - w / 2;
                    self.index--;
                }
                var t2 = self.index * self.spanWidth;
                if (self.index < 0 || self.index > self.count - 1) {
                    var left = parseInt(self.current.style.left), n;
                    if (self.index < 0) {
                        self.index = 0;
                        t2 = self.spanWidth * (self.count - 1);
                    }
                    if (self.index > self.count - 1) {
                        self.index = self.count - 1;
                        t2 = 0;
                    }
                    n = Math.floor((t2 - left) / self.spanWidth);
                    t1 = self.bank.scrollLeft + w / 2 * n;
                    self.index += n;
                }
                target[0] = t1;
                target[1] = t2;
                this.doRoll = setInterval(function () {
                    self.doing(self, step, target);
                }, this.time);
            }
        }

        this.doSrcoll = function (step, target) {
            if (step[0] != 0) {
                this.bank.scrollLeft += step[0];
                var left = parseInt(this.current.style.left) + step[1];
                this.current.style.left = left + 'px';
                this.current.innerHTML = this.index + 1;
                this.check = false;
                this.che = true;
            } else {
                this.bank.scrollLeft = target[0];
                this.current.style.left = target[1] + 'px';
                clearInterval(this.doRoll);
                clearInterval(this.checkedRoll);
                this.check = true;
                this.che = false;
            }
        }

        this.doing = function (self, step, target) {
            var now = self.bank.scrollLeft;
            var left = parseInt(self.current.style.left);
            step[0] = self.getStep(target[0], now, self.speed);
            step[1] = self.getStep(target[1], left, self.speed);
            self.doSrcoll(step, target);
        }

        this.checkRoll = function (x, e) {
            clearTimeout(this.autoed);
            clearInterval(this.doRoll);
            clearInterval(this.checkedRoll);
            var left = parseInt(this.current.style.left);
            var n = Math.floor((x - left) / this.spanWidth);
            this.index += n;
            var target = [], step = [];
            target[0] = this.bank.scrollLeft + n * this.bank.offsetWidth / 2;
            target[1] = left + n * this.spanWidth;
            var self = this;
            this.checkedRoll = setInterval(function () {
                self.doing(self, step, target);
            }, this.time);
        }

        this.getStep = function (target, now, speed) {
            var step = (target - now) / speed;
            if (step == 0) return 0;
            if (Math.abs(step) < 1) return (step > 0 ? 1 : -1);
            return step;
        }
    }

    return {
        create: function (id, pros) {
            var IMG = new imageFlow(id, pros);
            IMG.start();
        }
    }
})();

