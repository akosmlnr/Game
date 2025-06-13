using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C1 RID: 1729
	public class JournalApp : App<JournalApp>
	{
		// Token: 0x06009910 RID: 39184 RVA: 0x00275170 File Offset: 0x00273370
		// Note: this type is marked as 'beforefieldinit'.
		static JournalApp()
		{
			Il2CppClassPointerStore<JournalApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "JournalApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalApp>.NativeClassPtr);
			JournalApp.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "EntryContainer");
			JournalApp.NativeFieldInfoPtr_NoTasksLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "NoTasksLabel");
			JournalApp.NativeFieldInfoPtr_NoDetailsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "NoDetailsLabel");
			JournalApp.NativeFieldInfoPtr_DetailsPanelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "DetailsPanelContainer");
			JournalApp.NativeFieldInfoPtr_GenericEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericEntry");
			JournalApp.NativeFieldInfoPtr_GenericDetailsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericDetailsPanel");
			JournalApp.NativeFieldInfoPtr_GenericQuestEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericQuestEntry");
			JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "QuestHUDUIPrefab");
			JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "QuestEntryHUDUIPrefab");
			JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "currentDetailsPanelQuest");
			JournalApp.NativeFieldInfoPtr_currentDetailsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "currentDetailsPanel");
			JournalApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100682314);
			JournalApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100682315);
			JournalApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100682316);
			JournalApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100682317);
			JournalApp.NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100682318);
			JournalApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100682319);
			JournalApp.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100682320);
			JournalApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100682321);
		}

		// Token: 0x06009911 RID: 39185 RVA: 0x0027531C File Offset: 0x0027351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274304, XrefRangeEnd = 274307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x00275358 File Offset: 0x00273558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274307, XrefRangeEnd = 274326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x00275394 File Offset: 0x00273594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274326, XrefRangeEnd = 274336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x002753E0 File Offset: 0x002735E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274336, XrefRangeEnd = 274352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x0027541C File Offset: 0x0027361C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274366, RefRangeEnd = 274367, XrefRangeStart = 274352, XrefRangeEnd = 274366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDetailsPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JournalApp.NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009916 RID: 39190 RVA: 0x00275450 File Offset: 0x00273650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274367, XrefRangeEnd = 274386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x0027548C File Offset: 0x0027368C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274386, XrefRangeEnd = 274387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x002754C8 File Offset: 0x002736C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274387, XrefRangeEnd = 274393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JournalApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalApp>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JournalApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009919 RID: 39193 RVA: 0x0004A124 File Offset: 0x00048324
		public JournalApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x0600991A RID: 39194 RVA: 0x00275504 File Offset: 0x00273704
		// (set) Token: 0x0600991B RID: 39195 RVA: 0x0004A12D File Offset: 0x0004832D
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x0600991C RID: 39196 RVA: 0x00275534 File Offset: 0x00273734
		// (set) Token: 0x0600991D RID: 39197 RVA: 0x0004A14C File Offset: 0x0004834C
		public unsafe Text NoTasksLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoTasksLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoTasksLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x0600991E RID: 39198 RVA: 0x00275564 File Offset: 0x00273764
		// (set) Token: 0x0600991F RID: 39199 RVA: 0x0004A16B File Offset: 0x0004836B
		public unsafe Text NoDetailsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoDetailsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoDetailsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x06009920 RID: 39200 RVA: 0x00275594 File Offset: 0x00273794
		// (set) Token: 0x06009921 RID: 39201 RVA: 0x0004A18A File Offset: 0x0004838A
		public unsafe RectTransform DetailsPanelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_DetailsPanelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_DetailsPanelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x06009922 RID: 39202 RVA: 0x002755C4 File Offset: 0x002737C4
		// (set) Token: 0x06009923 RID: 39203 RVA: 0x0004A1A9 File Offset: 0x000483A9
		public unsafe GameObject GenericEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x06009924 RID: 39204 RVA: 0x002755F4 File Offset: 0x002737F4
		// (set) Token: 0x06009925 RID: 39205 RVA: 0x0004A1C8 File Offset: 0x000483C8
		public unsafe GameObject GenericDetailsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericDetailsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericDetailsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x06009926 RID: 39206 RVA: 0x00275624 File Offset: 0x00273824
		// (set) Token: 0x06009927 RID: 39207 RVA: 0x0004A1E7 File Offset: 0x000483E7
		public unsafe GameObject GenericQuestEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericQuestEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericQuestEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x06009928 RID: 39208 RVA: 0x00275654 File Offset: 0x00273854
		// (set) Token: 0x06009929 RID: 39209 RVA: 0x0004A206 File Offset: 0x00048406
		public unsafe QuestHUDUI QuestHUDUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x0600992A RID: 39210 RVA: 0x00275684 File Offset: 0x00273884
		// (set) Token: 0x0600992B RID: 39211 RVA: 0x0004A225 File Offset: 0x00048425
		public unsafe QuestEntryHUDUI QuestEntryHUDUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntryHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x0600992C RID: 39212 RVA: 0x002756B4 File Offset: 0x002738B4
		// (set) Token: 0x0600992D RID: 39213 RVA: 0x0004A244 File Offset: 0x00048444
		public unsafe Quest currentDetailsPanelQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0600992E RID: 39214 RVA: 0x002756E4 File Offset: 0x002738E4
		// (set) Token: 0x0600992F RID: 39215 RVA: 0x0004A263 File Offset: 0x00048463
		public unsafe RectTransform currentDetailsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006731 RID: 26417
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04006732 RID: 26418
		private static readonly IntPtr NativeFieldInfoPtr_NoTasksLabel;

		// Token: 0x04006733 RID: 26419
		private static readonly IntPtr NativeFieldInfoPtr_NoDetailsLabel;

		// Token: 0x04006734 RID: 26420
		private static readonly IntPtr NativeFieldInfoPtr_DetailsPanelContainer;

		// Token: 0x04006735 RID: 26421
		private static readonly IntPtr NativeFieldInfoPtr_GenericEntry;

		// Token: 0x04006736 RID: 26422
		private static readonly IntPtr NativeFieldInfoPtr_GenericDetailsPanel;

		// Token: 0x04006737 RID: 26423
		private static readonly IntPtr NativeFieldInfoPtr_GenericQuestEntry;

		// Token: 0x04006738 RID: 26424
		private static readonly IntPtr NativeFieldInfoPtr_QuestHUDUIPrefab;

		// Token: 0x04006739 RID: 26425
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryHUDUIPrefab;

		// Token: 0x0400673A RID: 26426
		private static readonly IntPtr NativeFieldInfoPtr_currentDetailsPanelQuest;

		// Token: 0x0400673B RID: 26427
		private static readonly IntPtr NativeFieldInfoPtr_currentDetailsPanel;

		// Token: 0x0400673C RID: 26428
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400673D RID: 26429
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400673E RID: 26430
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400673F RID: 26431
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006740 RID: 26432
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0;

		// Token: 0x04006741 RID: 26433
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006742 RID: 26434
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006743 RID: 26435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
