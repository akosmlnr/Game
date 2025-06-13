using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000659 RID: 1625
	[System.Serializable]
	public class DialogueChoiceEntry : Il2CppSystem.Object
	{
		// Token: 0x06008EA4 RID: 36516 RVA: 0x002561B8 File Offset: 0x002543B8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChoiceEntry()
		{
			Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DialogueChoiceEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr);
			DialogueChoiceEntry.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "gameObject");
			DialogueChoiceEntry.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "text");
			DialogueChoiceEntry.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "button");
			DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "notPossibleGameObject");
			DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "notPossibleText");
			DialogueChoiceEntry.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "canvasGroup");
			DialogueChoiceEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100681109);
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x00256274 File Offset: 0x00254474
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EA6 RID: 36518 RVA: 0x000441CE File Offset: 0x000423CE
		public DialogueChoiceEntry(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x06008EA7 RID: 36519 RVA: 0x002562B0 File Offset: 0x002544B0
		// (set) Token: 0x06008EA8 RID: 36520 RVA: 0x000441D7 File Offset: 0x000423D7
		public unsafe GameObject gameObject
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_gameObject);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x06008EA9 RID: 36521 RVA: 0x002562E0 File Offset: 0x002544E0
		// (set) Token: 0x06008EAA RID: 36522 RVA: 0x000441F6 File Offset: 0x000423F6
		public unsafe TextMeshProUGUI text
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_text);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x06008EAB RID: 36523 RVA: 0x00256310 File Offset: 0x00254510
		// (set) Token: 0x06008EAC RID: 36524 RVA: 0x00044215 File Offset: 0x00042415
		public unsafe Button button
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_button);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x06008EAD RID: 36525 RVA: 0x00256340 File Offset: 0x00254540
		// (set) Token: 0x06008EAE RID: 36526 RVA: 0x00044234 File Offset: 0x00042434
		public unsafe GameObject notPossibleGameObject
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleGameObject);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x06008EAF RID: 36527 RVA: 0x00256370 File Offset: 0x00254570
		// (set) Token: 0x06008EB0 RID: 36528 RVA: 0x00044253 File Offset: 0x00042453
		public unsafe TextMeshProUGUI notPossibleText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x06008EB1 RID: 36529 RVA: 0x002563A0 File Offset: 0x002545A0
		// (set) Token: 0x06008EB2 RID: 36530 RVA: 0x00044272 File Offset: 0x00042472
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_canvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060B8 RID: 24760
		private static readonly System.IntPtr NativeFieldInfoPtr_gameObject;

		// Token: 0x040060B9 RID: 24761
		private static readonly System.IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040060BA RID: 24762
		private static readonly System.IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040060BB RID: 24763
		private static readonly System.IntPtr NativeFieldInfoPtr_notPossibleGameObject;

		// Token: 0x040060BC RID: 24764
		private static readonly System.IntPtr NativeFieldInfoPtr_notPossibleText;

		// Token: 0x040060BD RID: 24765
		private static readonly System.IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x040060BE RID: 24766
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
