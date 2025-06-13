using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020006AE RID: 1710
	public class GameSettingsWindow : MonoBehaviour
	{
		// Token: 0x0600980E RID: 38926 RVA: 0x00271EB8 File Offset: 0x002700B8
		// Note: this type is marked as 'beforefieldinit'.
		static GameSettingsWindow()
		{
			Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "GameSettingsWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr);
			GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "ConsoleToggle");
			GameSettingsWindow.NativeFieldInfoPtr_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "Blocker");
			GameSettingsWindow.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100682184);
			GameSettingsWindow.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100682185);
			GameSettingsWindow.NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100682186);
			GameSettingsWindow.NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100682187);
			GameSettingsWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100682188);
		}

		// Token: 0x0600980F RID: 38927 RVA: 0x00271F74 File Offset: 0x00270174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272900, XrefRangeEnd = 272910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009810 RID: 38928 RVA: 0x00271FA8 File Offset: 0x002701A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272910, XrefRangeEnd = 272918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009811 RID: 38929 RVA: 0x00271FDC File Offset: 0x002701DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272918, XrefRangeEnd = 272920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings(GameSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009812 RID: 38930 RVA: 0x00272020 File Offset: 0x00270220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272920, XrefRangeEnd = 272924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsoleToggled(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009813 RID: 38931 RVA: 0x00272060 File Offset: 0x00270260
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSettingsWindow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009814 RID: 38932 RVA: 0x00049A2F File Offset: 0x00047C2F
		public GameSettingsWindow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x06009815 RID: 38933 RVA: 0x0027209C File Offset: 0x0027029C
		// (set) Token: 0x06009816 RID: 38934 RVA: 0x00049A38 File Offset: 0x00047C38
		public unsafe Toggle ConsoleToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x06009817 RID: 38935 RVA: 0x002720CC File Offset: 0x002702CC
		// (set) Token: 0x06009818 RID: 38936 RVA: 0x00049A57 File Offset: 0x00047C57
		public unsafe GameObject Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006690 RID: 26256
		private static readonly IntPtr NativeFieldInfoPtr_ConsoleToggle;

		// Token: 0x04006691 RID: 26257
		private static readonly IntPtr NativeFieldInfoPtr_Blocker;

		// Token: 0x04006692 RID: 26258
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006693 RID: 26259
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006694 RID: 26260
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0;

		// Token: 0x04006695 RID: 26261
		private static readonly IntPtr NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0;

		// Token: 0x04006696 RID: 26262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
