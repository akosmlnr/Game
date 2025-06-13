using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D3 RID: 723
	[Serializable]
	public class ShopManagerData : SaveData
	{
		// Token: 0x06003319 RID: 13081 RVA: 0x0011618C File Offset: 0x0011438C
		// Note: this type is marked as 'beforefieldinit'.
		static ShopManagerData()
		{
			Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ShopManagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr);
			ShopManagerData.NativeFieldInfoPtr_Shops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr, "Shops");
			ShopManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ShopData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr, 100669094);
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x001161E4 File Offset: 0x001143E4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136201, XrefRangeEnd = 136212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopManagerData(Il2CppReferenceArray<ShopData> shops) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shops);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ShopData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x0001B1D7 File Offset: 0x000193D7
		public ShopManagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x0600331C RID: 13084 RVA: 0x00116230 File Offset: 0x00114430
		// (set) Token: 0x0600331D RID: 13085 RVA: 0x0001B1E0 File Offset: 0x000193E0
		public unsafe Il2CppReferenceArray<ShopData> Shops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopManagerData.NativeFieldInfoPtr_Shops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShopData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopManagerData.NativeFieldInfoPtr_Shops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400212F RID: 8495
		private static readonly IntPtr NativeFieldInfoPtr_Shops;

		// Token: 0x04002130 RID: 8496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ShopData_0;
	}
}
