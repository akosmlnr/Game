using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200046A RID: 1130
	[System.Serializable]
	public class DialogueNodeData : Il2CppSystem.Object
	{
		// Token: 0x0600617C RID: 24956 RVA: 0x001C1388 File Offset: 0x001BF588
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueNodeData()
		{
			Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr);
			DialogueNodeData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "Guid");
			DialogueNodeData.NativeFieldInfoPtr_DialogueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "DialogueText");
			DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "DialogueNodeLabel");
			DialogueNodeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "Position");
			DialogueNodeData.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "choices");
			DialogueNodeData.NativeFieldInfoPtr_VoiceLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "VoiceLine");
			DialogueNodeData.NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, 100675836);
			DialogueNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, 100675837);
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x001C1458 File Offset: 0x001BF658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203176, XrefRangeEnd = 203185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeData.NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x001C1498 File Offset: 0x001BF698
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x0002DBC3 File Offset: 0x0002BDC3
		public DialogueNodeData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06006180 RID: 24960 RVA: 0x001C14D4 File Offset: 0x001BF6D4
		// (set) Token: 0x06006181 RID: 24961 RVA: 0x0002DBCC File Offset: 0x0002BDCC
		public unsafe string Guid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06006182 RID: 24962 RVA: 0x001C14FC File Offset: 0x001BF6FC
		// (set) Token: 0x06006183 RID: 24963 RVA: 0x0002DBEB File Offset: 0x0002BDEB
		public unsafe string DialogueText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06006184 RID: 24964 RVA: 0x001C1524 File Offset: 0x001BF724
		// (set) Token: 0x06006185 RID: 24965 RVA: 0x0002DC0A File Offset: 0x0002BE0A
		public unsafe string DialogueNodeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06006186 RID: 24966 RVA: 0x001C154C File Offset: 0x001BF74C
		// (set) Token: 0x06006187 RID: 24967 RVA: 0x0002DC29 File Offset: 0x0002BE29
		public unsafe Vector2 Position
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06006188 RID: 24968 RVA: 0x001C1574 File Offset: 0x001BF774
		// (set) Token: 0x06006189 RID: 24969 RVA: 0x0002DC44 File Offset: 0x0002BE44
		public unsafe Il2CppReferenceArray<DialogueChoiceData> choices
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_choices);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueChoiceData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x0600618A RID: 24970 RVA: 0x001C15A4 File Offset: 0x001BF7A4
		// (set) Token: 0x0600618B RID: 24971 RVA: 0x0002DC63 File Offset: 0x0002BE63
		public unsafe EVOLineType VoiceLine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_VoiceLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_VoiceLine)) = value;
			}
		}

		// Token: 0x040042A8 RID: 17064
		private static readonly System.IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x040042A9 RID: 17065
		private static readonly System.IntPtr NativeFieldInfoPtr_DialogueText;

		// Token: 0x040042AA RID: 17066
		private static readonly System.IntPtr NativeFieldInfoPtr_DialogueNodeLabel;

		// Token: 0x040042AB RID: 17067
		private static readonly System.IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x040042AC RID: 17068
		private static readonly System.IntPtr NativeFieldInfoPtr_choices;

		// Token: 0x040042AD RID: 17069
		private static readonly System.IntPtr NativeFieldInfoPtr_VoiceLine;

		// Token: 0x040042AE RID: 17070
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0;

		// Token: 0x040042AF RID: 17071
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
