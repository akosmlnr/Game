using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.MainMenu;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x02000177 RID: 375
	public class CommandListScreen : MainMenuScreen
	{
		// Token: 0x06001DE9 RID: 7657 RVA: 0x000D0790 File Offset: 0x000CE990
		// Note: this type is marked as 'beforefieldinit'.
		static CommandListScreen()
		{
			Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "CommandListScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr);
			CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "CommandEntryContainer");
			CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "CommandEntryPrefab");
			CommandListScreen.NativeFieldInfoPtr_commandEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "commandEntries");
			CommandListScreen.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, 100666737);
			CommandListScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, 100666738);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000D0824 File Offset: 0x000CEA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109659, XrefRangeEnd = 109709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandListScreen.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000D0858 File Offset: 0x000CEA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109709, XrefRangeEnd = 109717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandListScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandListScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00010C8B File Offset: 0x0000EE8B
		public CommandListScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x000D0894 File Offset: 0x000CEA94
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x00010C94 File Offset: 0x0000EE94
		public unsafe RectTransform CommandEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x000D08C4 File Offset: 0x000CEAC4
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x00010CB3 File Offset: 0x0000EEB3
		public unsafe RectTransform CommandEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x000D08F4 File Offset: 0x000CEAF4
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x00010CD2 File Offset: 0x0000EED2
		public unsafe List<RectTransform> commandEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_commandEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_commandEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeFieldInfoPtr_CommandEntryContainer;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeFieldInfoPtr_CommandEntryPrefab;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeFieldInfoPtr_commandEntries;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
