using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000438 RID: 1080
	public class CustomerSatisfaction : Il2CppSystem.Object
	{
		// Token: 0x06005D8F RID: 23951 RVA: 0x001B35B8 File Offset: 0x001B17B8
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerSatisfaction()
		{
			Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerSatisfaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr);
			CustomerSatisfaction.NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr, 100675308);
			CustomerSatisfaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr, 100675309);
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x001B3610 File Offset: 0x001B1810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197830, RefRangeEnd = 197831, XrefRangeStart = 197830, XrefRangeEnd = 197830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetRelationshipChange(float satisfaction)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref satisfaction;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CustomerSatisfaction.NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x001B3650 File Offset: 0x001B1850
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerSatisfaction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSatisfaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x0002BEBB File Offset: 0x0002A0BB
		public CustomerSatisfaction(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003FF8 RID: 16376
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0;

		// Token: 0x04003FF9 RID: 16377
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
