using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x02000229 RID: 553
	public static class ItemDeserializer : Il2CppSystem.Object
	{
		// Token: 0x06002D79 RID: 11641 RVA: 0x0001859F File Offset: 0x0001679F
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDeserializer()
		{
			Il2CppClassPointerStore<ItemDeserializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "ItemDeserializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDeserializer>.NativeClassPtr);
			ItemDeserializer.NativeMethodInfoPtr_LoadItem_Public_Static_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDeserializer>.NativeClassPtr, 100668474);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00103E28 File Offset: 0x00102028
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 128178, RefRangeEnd = 128220, XrefRangeStart = 128142, XrefRangeEnd = 128178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance LoadItem(string itemString)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDeserializer.NativeMethodInfoPtr_LoadItem_Public_Static_ItemInstance_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000185D8 File Offset: 0x000167D8
		public ItemDeserializer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E2E RID: 7726
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadItem_Public_Static_ItemInstance_String_0;
	}
}
