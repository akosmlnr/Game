using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027E RID: 638
	[Serializable]
	public class CocaineData : ProductItemData
	{
		// Token: 0x06003063 RID: 12387 RVA: 0x0001951C File Offset: 0x0001771C
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineData()
		{
			Il2CppClassPointerStore<CocaineData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CocaineData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineData>.NativeClassPtr);
			CocaineData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineData>.NativeClassPtr, 100669002);
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x0010E680 File Offset: 0x0010C880
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136642, RefRangeEnd = 136646, XrefRangeStart = 136638, XrefRangeEnd = 136642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00019555 File Offset: 0x00017755
		public CocaineData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}
