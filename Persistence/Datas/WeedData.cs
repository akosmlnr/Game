using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000288 RID: 648
	[Serializable]
	public class WeedData : ProductItemData
	{
		// Token: 0x06003095 RID: 12437 RVA: 0x0001973F File Offset: 0x0001793F
		// Note: this type is marked as 'beforefieldinit'.
		static WeedData()
		{
			Il2CppClassPointerStore<WeedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WeedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedData>.NativeClassPtr);
			WeedData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedData>.NativeClassPtr, 100669012);
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x0010EEE0 File Offset: 0x0010D0E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136642, RefRangeEnd = 136646, XrefRangeStart = 136642, XrefRangeEnd = 136646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00019778 File Offset: 0x00017978
		public WeedData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}
