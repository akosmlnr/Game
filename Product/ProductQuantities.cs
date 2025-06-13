using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005CD RID: 1485
	public static class ProductQuantities : Il2CppSystem.Object
	{
		// Token: 0x060081B8 RID: 33208 RVA: 0x0022E0D8 File Offset: 0x0022C2D8
		// Note: this type is marked as 'beforefieldinit'.
		static ProductQuantities()
		{
			Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductQuantities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr);
			ProductQuantities.NativeFieldInfoPtr_BagQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "BagQuantity");
			ProductQuantities.NativeFieldInfoPtr_JarQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "JarQuantity");
			ProductQuantities.NativeFieldInfoPtr_BrickQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "BrickQuantity");
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x0003D2FD File Offset: 0x0003B4FD
		public ProductQuantities(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x060081BA RID: 33210 RVA: 0x0022E144 File Offset: 0x0022C344
		// (set) Token: 0x060081BB RID: 33211 RVA: 0x0003D306 File Offset: 0x0003B506
		public unsafe static int BagQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_BagQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_BagQuantity, (void*)(&value));
			}
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x060081BC RID: 33212 RVA: 0x0022E160 File Offset: 0x0022C360
		// (set) Token: 0x060081BD RID: 33213 RVA: 0x0003D314 File Offset: 0x0003B514
		public unsafe static int JarQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_JarQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_JarQuantity, (void*)(&value));
			}
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x060081BE RID: 33214 RVA: 0x0022E17C File Offset: 0x0022C37C
		// (set) Token: 0x060081BF RID: 33215 RVA: 0x0003D322 File Offset: 0x0003B522
		public unsafe static int BrickQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_BrickQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_BrickQuantity, (void*)(&value));
			}
		}

		// Token: 0x04005874 RID: 22644
		private static readonly System.IntPtr NativeFieldInfoPtr_BagQuantity;

		// Token: 0x04005875 RID: 22645
		private static readonly System.IntPtr NativeFieldInfoPtr_JarQuantity;

		// Token: 0x04005876 RID: 22646
		private static readonly System.IntPtr NativeFieldInfoPtr_BrickQuantity;
	}
}
