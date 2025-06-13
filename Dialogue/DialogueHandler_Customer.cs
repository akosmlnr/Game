using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200045F RID: 1119
	public class DialogueHandler_Customer : DialogueHandler
	{
		// Token: 0x06006113 RID: 24851 RVA: 0x0002D892 File Offset: 0x0002BA92
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_Customer()
		{
			Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_Customer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr);
			DialogueHandler_Customer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr, 100675765);
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x001BFD0C File Offset: 0x001BDF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_Customer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_Customer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x0002D8CB File Offset: 0x0002BACB
		public DialogueHandler_Customer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004261 RID: 16993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
