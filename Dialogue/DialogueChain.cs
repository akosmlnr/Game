using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000459 RID: 1113
	[System.Serializable]
	public class DialogueChain : Il2CppSystem.Object
	{
		// Token: 0x0600608E RID: 24718 RVA: 0x001BDFA0 File Offset: 0x001BC1A0
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChain()
		{
			Il2CppClassPointerStore<DialogueChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr);
			DialogueChain.NativeFieldInfoPtr_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, "Lines");
			DialogueChain.NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, 100675696);
			DialogueChain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, 100675697);
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x001BE00C File Offset: 0x001BC20C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 201955, RefRangeEnd = 201969, XrefRangeStart = 201947, XrefRangeEnd = 201955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetMessageChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChain.NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x001BE04C File Offset: 0x001BC24C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x0002D4A4 File Offset: 0x0002B6A4
		public DialogueChain(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06006092 RID: 24722 RVA: 0x001BE088 File Offset: 0x001BC288
		// (set) Token: 0x06006093 RID: 24723 RVA: 0x0002D4AD File Offset: 0x0002B6AD
		public unsafe Il2CppStringArray Lines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChain.NativeFieldInfoPtr_Lines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChain.NativeFieldInfoPtr_Lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400420A RID: 16906
		private static readonly System.IntPtr NativeFieldInfoPtr_Lines;

		// Token: 0x0400420B RID: 16907
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0;

		// Token: 0x0400420C RID: 16908
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
