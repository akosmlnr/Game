using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066A RID: 1642
	public class ItemSelector : Singleton<ItemSelector>
	{
		// Token: 0x06009077 RID: 36983 RVA: 0x000452C6 File Offset: 0x000434C6
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelector()
		{
			Il2CppClassPointerStore<ItemSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ItemSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr);
			ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100681331);
		}

		// Token: 0x06009078 RID: 36984 RVA: 0x0025B8D4 File Offset: 0x00259AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262604, XrefRangeEnd = 262607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009079 RID: 36985 RVA: 0x000452FF File Offset: 0x000434FF
		public ItemSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040061DA RID: 25050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
