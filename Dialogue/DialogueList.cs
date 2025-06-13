using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000458 RID: 1112
	[System.Serializable]
	public class DialogueList : Il2CppSystem.Object
	{
		// Token: 0x06006088 RID: 24712 RVA: 0x001BDE90 File Offset: 0x001BC090
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueList()
		{
			Il2CppClassPointerStore<DialogueList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueList>.NativeClassPtr);
			DialogueList.NativeFieldInfoPtr_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, "Lines");
			DialogueList.NativeMethodInfoPtr_GetRandomLine_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, 100675694);
			DialogueList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, 100675695);
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x001BDEFC File Offset: 0x001BC0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201945, XrefRangeEnd = 201947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRandomLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DialogueList.NativeMethodInfoPtr_GetRandomLine_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x001BDF34 File Offset: 0x001BC134
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueList>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x0002D47C File Offset: 0x0002B67C
		public DialogueList(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x001BDF70 File Offset: 0x001BC170
		// (set) Token: 0x0600608D RID: 24717 RVA: 0x0002D485 File Offset: 0x0002B685
		public unsafe Il2CppStringArray Lines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueList.NativeFieldInfoPtr_Lines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueList.NativeFieldInfoPtr_Lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004207 RID: 16903
		private static readonly System.IntPtr NativeFieldInfoPtr_Lines;

		// Token: 0x04004208 RID: 16904
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomLine_Public_String_0;

		// Token: 0x04004209 RID: 16905
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
