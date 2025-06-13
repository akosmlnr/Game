using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200042F RID: 1071
	[System.Serializable]
	public class ProductTypeAffinity : Il2CppSystem.Object
	{
		// Token: 0x06005BEE RID: 23534 RVA: 0x001AD434 File Offset: 0x001AB634
		// Note: this type is marked as 'beforefieldinit'.
		static ProductTypeAffinity()
		{
			Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "ProductTypeAffinity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr);
			ProductTypeAffinity.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, "DrugType");
			ProductTypeAffinity.NativeFieldInfoPtr_Affinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, "Affinity");
			ProductTypeAffinity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, 100675089);
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x001AD4A0 File Offset: 0x001AB6A0
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductTypeAffinity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeAffinity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x0002B360 File Offset: 0x00029560
		public ProductTypeAffinity(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06005BF1 RID: 23537 RVA: 0x001AD4DC File Offset: 0x001AB6DC
		// (set) Token: 0x06005BF2 RID: 23538 RVA: 0x0002B369 File Offset: 0x00029569
		public unsafe EDrugType DrugType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06005BF3 RID: 23539 RVA: 0x001AD504 File Offset: 0x001AB704
		// (set) Token: 0x06005BF4 RID: 23540 RVA: 0x0002B384 File Offset: 0x00029584
		public unsafe float Affinity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_Affinity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_Affinity)) = value;
			}
		}

		// Token: 0x04003EC7 RID: 16071
		private static readonly System.IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x04003EC8 RID: 16072
		private static readonly System.IntPtr NativeFieldInfoPtr_Affinity;

		// Token: 0x04003EC9 RID: 16073
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
