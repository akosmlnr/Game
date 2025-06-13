using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x02000171 RID: 369
	public class Console : Singleton<Console>
	{
		// Token: 0x06001D52 RID: 7506 RVA: 0x000CE60C File Offset: 0x000CC80C
		// Note: this type is marked as 'beforefieldinit'.
		static Console()
		{
			Il2CppClassPointerStore<Console>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "Console");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console>.NativeClassPtr);
			Console.NativeFieldInfoPtr_TeleportPointsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "TeleportPointsContainer");
			Console.NativeFieldInfoPtr_LabelledGameObjectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "LabelledGameObjectList");
			Console.NativeFieldInfoPtr_startupCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "startupCommands");
			Console.NativeFieldInfoPtr_Commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "Commands");
			Console.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "commands");
			Console.NativeFieldInfoPtr_keyBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "keyBindings");
			Console.NativeMethodInfoPtr_get_player_Private_Static_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666399);
			Console.NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666400);
			Console.NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666401);
			Console.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666402);
			Console.NativeMethodInfoPtr_RunStartupCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666403);
			Console.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666404);
			Console.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666405);
			Console.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666406);
			Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666407);
			Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666408);
			Console.NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666409);
			Console.NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666410);
			Console.NativeMethodInfoPtr_ClearBindings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666411);
			Console.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666412);
			Console.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666413);
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x000CE7E0 File Offset: 0x000CC9E0
		public unsafe static Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106047, XrefRangeEnd = 106051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_player_Private_Static_get_Player_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000CE814 File Offset: 0x000CCA14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 106058, RefRangeEnd = 106063, XrefRangeStart = 106051, XrefRangeEnd = 106058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogCommandError(string error)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x000CE84C File Offset: 0x000CCA4C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 106084, RefRangeEnd = 106096, XrefRangeStart = 106063, XrefRangeEnd = 106084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogUnrecognizedFormat(Il2CppStringArray correctExamples)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(correctExamples);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x000CE884 File Offset: 0x000CCA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106096, XrefRangeEnd = 106561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x000CE8C0 File Offset: 0x000CCAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106561, XrefRangeEnd = 106587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunStartupCommands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_RunStartupCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x000CE8F4 File Offset: 0x000CCAF4
		[CallerCount(332)]
		[CachedScanResults(RefRangeStart = 106591, RefRangeEnd = 106923, XrefRangeStart = 106587, XrefRangeEnd = 106591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x000CE93C File Offset: 0x000CCB3C
		[CallerCount(326)]
		[CachedScanResults(RefRangeStart = 106927, RefRangeEnd = 107253, XrefRangeStart = 106923, XrefRangeEnd = 106927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x000CE984 File Offset: 0x000CCB84
		[CallerCount(216)]
		[CachedScanResults(RefRangeStart = 107257, RefRangeEnd = 107473, XrefRangeStart = 107253, XrefRangeEnd = 107257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x000CE9CC File Offset: 0x000CCBCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107511, RefRangeEnd = 107512, XrefRangeStart = 107473, XrefRangeEnd = 107511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubmitCommand(List<string> args)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x000CEA04 File Offset: 0x000CCC04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107528, RefRangeEnd = 107531, XrefRangeStart = 107512, XrefRangeEnd = 107528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubmitCommand(string args)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(args);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x000CEA3C File Offset: 0x000CCC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107531, XrefRangeEnd = 107553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinding(KeyCode key, string command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref key;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(command);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x000CEA8C File Offset: 0x000CCC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107553, XrefRangeEnd = 107569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBinding(KeyCode key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref key;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000CEACC File Offset: 0x000CCCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107569, XrefRangeEnd = 107582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ClearBindings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000CEB00 File Offset: 0x000CCD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107582, XrefRangeEnd = 107611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x000CEB34 File Offset: 0x000CCD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107611, XrefRangeEnd = 107628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Console() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x000109B1 File Offset: 0x0000EBB1
		public Console(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x000CEB70 File Offset: 0x000CCD70
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x000109BA File Offset: 0x0000EBBA
		public unsafe Transform TeleportPointsContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_TeleportPointsContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_TeleportPointsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x000CEBA0 File Offset: 0x000CCDA0
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x000109D9 File Offset: 0x0000EBD9
		public unsafe List<Console.LabelledGameObject> LabelledGameObjectList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_LabelledGameObjectList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Console.LabelledGameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_LabelledGameObjectList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x000CEBD0 File Offset: 0x000CCDD0
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x000109F8 File Offset: 0x0000EBF8
		public unsafe List<string> startupCommands
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_startupCommands);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_startupCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x000CEC00 File Offset: 0x000CCE00
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x00010A17 File Offset: 0x0000EC17
		public unsafe static List<Console.ConsoleCommand> Commands
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_Commands, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Console.ConsoleCommand>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_Commands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x000CEC28 File Offset: 0x000CCE28
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x00010A29 File Offset: 0x0000EC29
		public unsafe static Dictionary<string, Console.ConsoleCommand> commands
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_commands, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Console.ConsoleCommand>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_commands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x000CEC50 File Offset: 0x000CCE50
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00010A3B File Offset: 0x0000EC3B
		public unsafe Dictionary<KeyCode, string> keyBindings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_keyBindings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<KeyCode, string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_keyBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001369 RID: 4969
		private static readonly System.IntPtr NativeFieldInfoPtr_TeleportPointsContainer;

		// Token: 0x0400136A RID: 4970
		private static readonly System.IntPtr NativeFieldInfoPtr_LabelledGameObjectList;

		// Token: 0x0400136B RID: 4971
		private static readonly System.IntPtr NativeFieldInfoPtr_startupCommands;

		// Token: 0x0400136C RID: 4972
		private static readonly System.IntPtr NativeFieldInfoPtr_Commands;

		// Token: 0x0400136D RID: 4973
		private static readonly System.IntPtr NativeFieldInfoPtr_commands;

		// Token: 0x0400136E RID: 4974
		private static readonly System.IntPtr NativeFieldInfoPtr_keyBindings;

		// Token: 0x0400136F RID: 4975
		private static readonly System.IntPtr NativeMethodInfoPtr_get_player_Private_Static_get_Player_0;

		// Token: 0x04001370 RID: 4976
		private static readonly System.IntPtr NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0;

		// Token: 0x04001371 RID: 4977
		private static readonly System.IntPtr NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0;

		// Token: 0x04001372 RID: 4978
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001373 RID: 4979
		private static readonly System.IntPtr NativeMethodInfoPtr_RunStartupCommands_Private_Void_0;

		// Token: 0x04001374 RID: 4980
		private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;

		// Token: 0x04001375 RID: 4981
		private static readonly System.IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;

		// Token: 0x04001376 RID: 4982
		private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;

		// Token: 0x04001377 RID: 4983
		private static readonly System.IntPtr NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0;

		// Token: 0x04001378 RID: 4984
		private static readonly System.IntPtr NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0;

		// Token: 0x04001379 RID: 4985
		private static readonly System.IntPtr NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0;

		// Token: 0x0400137A RID: 4986
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0;

		// Token: 0x0400137B RID: 4987
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearBindings_Public_Void_0;

		// Token: 0x0400137C RID: 4988
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400137D RID: 4989
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200089F RID: 2207
		public class ConsoleCommand : Il2CppSystem.Object
		{
			// Token: 0x0600C5AB RID: 50603 RVA: 0x003067B0 File Offset: 0x003049B0
			// Note: this type is marked as 'beforefieldinit'.
			static ConsoleCommand()
			{
				Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ConsoleCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666415);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666416);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666417);
				Console.ConsoleCommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666418);
				Console.ConsoleCommand.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666419);
			}

			// Token: 0x17003D4E RID: 15694
			// (get) Token: 0x0600C5AC RID: 50604 RVA: 0x00306840 File Offset: 0x00304A40
			public unsafe virtual string CommandWord
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D4F RID: 15695
			// (get) Token: 0x0600C5AD RID: 50605 RVA: 0x00306884 File Offset: 0x00304A84
			public unsafe virtual string CommandDescription
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D50 RID: 15696
			// (get) Token: 0x0600C5AE RID: 50606 RVA: 0x003068C8 File Offset: 0x00304AC8
			public unsafe virtual string ExampleUsage
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5AF RID: 50607 RVA: 0x0030690C File Offset: 0x00304B0C
			[CallerCount(0)]
			public unsafe virtual void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5B0 RID: 50608 RVA: 0x0030695C File Offset: 0x00304B5C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConsoleCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ConsoleCommand.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5B1 RID: 50609 RVA: 0x0006050E File Offset: 0x0005E70E
			public ConsoleCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040085F3 RID: 34291
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040085F4 RID: 34292
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040085F5 RID: 34293
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040085F6 RID: 34294
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0;

			// Token: 0x040085F7 RID: 34295
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x020008A0 RID: 2208
		public class SetTimeCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C5B2 RID: 50610 RVA: 0x00306998 File Offset: 0x00304B98
			// Note: this type is marked as 'beforefieldinit'.
			static SetTimeCommand()
			{
				Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetTimeCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666420);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666421);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666422);
				Console.SetTimeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666423);
				Console.SetTimeCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666424);
			}

			// Token: 0x17003D51 RID: 15697
			// (get) Token: 0x0600C5B3 RID: 50611 RVA: 0x00306A28 File Offset: 0x00304C28
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104664, XrefRangeEnd = 104666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D52 RID: 15698
			// (get) Token: 0x0600C5B4 RID: 50612 RVA: 0x00306A6C File Offset: 0x00304C6C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104666, XrefRangeEnd = 104668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D53 RID: 15699
			// (get) Token: 0x0600C5B5 RID: 50613 RVA: 0x00306AB0 File Offset: 0x00304CB0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104668, XrefRangeEnd = 104670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5B6 RID: 50614 RVA: 0x00306AF4 File Offset: 0x00304CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104670, XrefRangeEnd = 104710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5B7 RID: 50615 RVA: 0x00306B44 File Offset: 0x00304D44
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetTimeCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetTimeCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5B8 RID: 50616 RVA: 0x00060517 File Offset: 0x0005E717
			public SetTimeCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040085F8 RID: 34296
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040085F9 RID: 34297
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040085FA RID: 34298
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040085FB RID: 34299
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040085FC RID: 34300
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A1 RID: 2209
		public class SpawnVehicleCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C5B9 RID: 50617 RVA: 0x00306B80 File Offset: 0x00304D80
			// Note: this type is marked as 'beforefieldinit'.
			static SpawnVehicleCommand()
			{
				Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SpawnVehicleCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666425);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666426);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666427);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666428);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666429);
			}

			// Token: 0x17003D54 RID: 15700
			// (get) Token: 0x0600C5BA RID: 50618 RVA: 0x00306C10 File Offset: 0x00304E10
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104710, XrefRangeEnd = 104712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D55 RID: 15701
			// (get) Token: 0x0600C5BB RID: 50619 RVA: 0x00306C54 File Offset: 0x00304E54
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104712, XrefRangeEnd = 104714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D56 RID: 15702
			// (get) Token: 0x0600C5BC RID: 50620 RVA: 0x00306C98 File Offset: 0x00304E98
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104714, XrefRangeEnd = 104716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5BD RID: 50621 RVA: 0x00306CDC File Offset: 0x00304EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104716, XrefRangeEnd = 104773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5BE RID: 50622 RVA: 0x00306D2C File Offset: 0x00304F2C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpawnVehicleCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SpawnVehicleCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5BF RID: 50623 RVA: 0x00060520 File Offset: 0x0005E720
			public SpawnVehicleCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040085FD RID: 34301
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040085FE RID: 34302
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040085FF RID: 34303
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008600 RID: 34304
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008601 RID: 34305
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A2 RID: 2210
		public class AddItemToInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C5C0 RID: 50624 RVA: 0x00306D68 File Offset: 0x00304F68
			// Note: this type is marked as 'beforefieldinit'.
			static AddItemToInventoryCommand()
			{
				Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "AddItemToInventoryCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666430);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666431);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666432);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666433);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666434);
			}

			// Token: 0x17003D57 RID: 15703
			// (get) Token: 0x0600C5C1 RID: 50625 RVA: 0x00306DF8 File Offset: 0x00304FF8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104773, XrefRangeEnd = 104775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D58 RID: 15704
			// (get) Token: 0x0600C5C2 RID: 50626 RVA: 0x00306E3C File Offset: 0x0030503C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104775, XrefRangeEnd = 104777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D59 RID: 15705
			// (get) Token: 0x0600C5C3 RID: 50627 RVA: 0x00306E80 File Offset: 0x00305080
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104777, XrefRangeEnd = 104779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5C4 RID: 50628 RVA: 0x00306EC4 File Offset: 0x003050C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104779, XrefRangeEnd = 104816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5C5 RID: 50629 RVA: 0x00306F14 File Offset: 0x00305114
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddItemToInventoryCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddItemToInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5C6 RID: 50630 RVA: 0x00060529 File Offset: 0x0005E729
			public AddItemToInventoryCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008602 RID: 34306
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008603 RID: 34307
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008604 RID: 34308
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008605 RID: 34309
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008606 RID: 34310
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A3 RID: 2211
		public class ClearInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C5C7 RID: 50631 RVA: 0x00306F50 File Offset: 0x00305150
			// Note: this type is marked as 'beforefieldinit'.
			static ClearInventoryCommand()
			{
				Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearInventoryCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666435);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666436);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666437);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666438);
				Console.ClearInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666439);
			}

			// Token: 0x17003D5A RID: 15706
			// (get) Token: 0x0600C5C8 RID: 50632 RVA: 0x00306FE0 File Offset: 0x003051E0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104816, XrefRangeEnd = 104818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D5B RID: 15707
			// (get) Token: 0x0600C5C9 RID: 50633 RVA: 0x00307024 File Offset: 0x00305224
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104818, XrefRangeEnd = 104820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D5C RID: 15708
			// (get) Token: 0x0600C5CA RID: 50634 RVA: 0x00307068 File Offset: 0x00305268
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104820, XrefRangeEnd = 104822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5CB RID: 50635 RVA: 0x003070AC File Offset: 0x003052AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104822, XrefRangeEnd = 104837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5CC RID: 50636 RVA: 0x003070FC File Offset: 0x003052FC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearInventoryCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5CD RID: 50637 RVA: 0x00060532 File Offset: 0x0005E732
			public ClearInventoryCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008607 RID: 34311
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008608 RID: 34312
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008609 RID: 34313
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400860A RID: 34314
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400860B RID: 34315
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A4 RID: 2212
		public class ChangeCashCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C5CE RID: 50638 RVA: 0x00307138 File Offset: 0x00305338
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeCashCommand()
			{
				Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ChangeCashCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666440);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666441);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666442);
				Console.ChangeCashCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666443);
				Console.ChangeCashCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666444);
			}

			// Token: 0x17003D5D RID: 15709
			// (get) Token: 0x0600C5CF RID: 50639 RVA: 0x003071C8 File Offset: 0x003053C8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104837, XrefRangeEnd = 104839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D5E RID: 15710
			// (get) Token: 0x0600C5D0 RID: 50640 RVA: 0x0030720C File Offset: 0x0030540C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104839, XrefRangeEnd = 104841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D5F RID: 15711
			// (get) Token: 0x0600C5D1 RID: 50641 RVA: 0x00307250 File Offset: 0x00305450
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104841, XrefRangeEnd = 104843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5D2 RID: 50642 RVA: 0x00307294 File Offset: 0x00305494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104843, XrefRangeEnd = 104869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5D3 RID: 50643 RVA: 0x003072E4 File Offset: 0x003054E4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeCashCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ChangeCashCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5D4 RID: 50644 RVA: 0x0006053B File Offset: 0x0005E73B
			public ChangeCashCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400860C RID: 34316
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400860D RID: 34317
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400860E RID: 34318
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400860F RID: 34319
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008610 RID: 34320
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A5 RID: 2213
		public class ChangeOnlineBalanceCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C5D5 RID: 50645 RVA: 0x00307320 File Offset: 0x00305520
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeOnlineBalanceCommand()
			{
				Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ChangeOnlineBalanceCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666445);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666446);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666447);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666448);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666449);
			}

			// Token: 0x17003D60 RID: 15712
			// (get) Token: 0x0600C5D6 RID: 50646 RVA: 0x003073B0 File Offset: 0x003055B0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104869, XrefRangeEnd = 104871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D61 RID: 15713
			// (get) Token: 0x0600C5D7 RID: 50647 RVA: 0x003073F4 File Offset: 0x003055F4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104871, XrefRangeEnd = 104873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D62 RID: 15714
			// (get) Token: 0x0600C5D8 RID: 50648 RVA: 0x00307438 File Offset: 0x00305638
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104873, XrefRangeEnd = 104875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5D9 RID: 50649 RVA: 0x0030747C File Offset: 0x0030567C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104875, XrefRangeEnd = 104903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5DA RID: 50650 RVA: 0x003074CC File Offset: 0x003056CC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeOnlineBalanceCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5DB RID: 50651 RVA: 0x00060544 File Offset: 0x0005E744
			public ChangeOnlineBalanceCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008611 RID: 34321
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008612 RID: 34322
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008613 RID: 34323
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008614 RID: 34324
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008615 RID: 34325
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A6 RID: 2214
		public class SetMoveSpeedCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C5DC RID: 50652 RVA: 0x00307508 File Offset: 0x00305708
			// Note: this type is marked as 'beforefieldinit'.
			static SetMoveSpeedCommand()
			{
				Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetMoveSpeedCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666450);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666451);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666452);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666453);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666454);
			}

			// Token: 0x17003D63 RID: 15715
			// (get) Token: 0x0600C5DD RID: 50653 RVA: 0x00307598 File Offset: 0x00305798
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104903, XrefRangeEnd = 104905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D64 RID: 15716
			// (get) Token: 0x0600C5DE RID: 50654 RVA: 0x003075DC File Offset: 0x003057DC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104905, XrefRangeEnd = 104907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D65 RID: 15717
			// (get) Token: 0x0600C5DF RID: 50655 RVA: 0x00307620 File Offset: 0x00305820
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104907, XrefRangeEnd = 104909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5E0 RID: 50656 RVA: 0x00307664 File Offset: 0x00305864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104909, XrefRangeEnd = 104927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5E1 RID: 50657 RVA: 0x003076B4 File Offset: 0x003058B4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetMoveSpeedCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetMoveSpeedCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5E2 RID: 50658 RVA: 0x0006054D File Offset: 0x0005E74D
			public SetMoveSpeedCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008616 RID: 34326
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008617 RID: 34327
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008618 RID: 34328
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008619 RID: 34329
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400861A RID: 34330
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A7 RID: 2215
		public class SetJumpMultiplier : Console.ConsoleCommand
		{
			// Token: 0x0600C5E3 RID: 50659 RVA: 0x003076F0 File Offset: 0x003058F0
			// Note: this type is marked as 'beforefieldinit'.
			static SetJumpMultiplier()
			{
				Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetJumpMultiplier");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666455);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666456);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666457);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666458);
				Console.SetJumpMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666459);
			}

			// Token: 0x17003D66 RID: 15718
			// (get) Token: 0x0600C5E4 RID: 50660 RVA: 0x00307780 File Offset: 0x00305980
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104927, XrefRangeEnd = 104929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D67 RID: 15719
			// (get) Token: 0x0600C5E5 RID: 50661 RVA: 0x003077C4 File Offset: 0x003059C4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104929, XrefRangeEnd = 104931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D68 RID: 15720
			// (get) Token: 0x0600C5E6 RID: 50662 RVA: 0x00307808 File Offset: 0x00305A08
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104931, XrefRangeEnd = 104933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5E7 RID: 50663 RVA: 0x0030784C File Offset: 0x00305A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104933, XrefRangeEnd = 104951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5E8 RID: 50664 RVA: 0x0030789C File Offset: 0x00305A9C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetJumpMultiplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetJumpMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5E9 RID: 50665 RVA: 0x00060556 File Offset: 0x0005E756
			public SetJumpMultiplier(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400861B RID: 34331
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400861C RID: 34332
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400861D RID: 34333
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400861E RID: 34334
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400861F RID: 34335
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A8 RID: 2216
		public class SetPropertyOwned : Console.ConsoleCommand
		{
			// Token: 0x0600C5EA RID: 50666 RVA: 0x003078D8 File Offset: 0x00305AD8
			// Note: this type is marked as 'beforefieldinit'.
			static SetPropertyOwned()
			{
				Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetPropertyOwned");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666460);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666461);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666462);
				Console.SetPropertyOwned.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666463);
				Console.SetPropertyOwned.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666464);
			}

			// Token: 0x17003D69 RID: 15721
			// (get) Token: 0x0600C5EB RID: 50667 RVA: 0x00307968 File Offset: 0x00305B68
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104975, XrefRangeEnd = 104977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D6A RID: 15722
			// (get) Token: 0x0600C5EC RID: 50668 RVA: 0x003079AC File Offset: 0x00305BAC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104977, XrefRangeEnd = 104979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D6B RID: 15723
			// (get) Token: 0x0600C5ED RID: 50669 RVA: 0x003079F0 File Offset: 0x00305BF0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104979, XrefRangeEnd = 104981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5EE RID: 50670 RVA: 0x00307A34 File Offset: 0x00305C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104981, XrefRangeEnd = 105010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5EF RID: 50671 RVA: 0x00307A84 File Offset: 0x00305C84
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetPropertyOwned() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5F0 RID: 50672 RVA: 0x0006055F File Offset: 0x0005E75F
			public SetPropertyOwned(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008620 RID: 34336
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008621 RID: 34337
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008622 RID: 34338
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008623 RID: 34339
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008624 RID: 34340
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C88 RID: 3208
			[ObfuscatedName("ScheduleOne.Console+SetPropertyOwned+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E6C0 RID: 59072 RVA: 0x00365E6C File Offset: 0x0036406C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100666465);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100666466);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100666467);
				}

				// Token: 0x0600E6C1 RID: 59073 RVA: 0x00365EE8 File Offset: 0x003640E8
				[CallerCount(2576)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr))
				{
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E6C2 RID: 59074 RVA: 0x00365F24 File Offset: 0x00364124
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104951, XrefRangeEnd = 104975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Property x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600E6C3 RID: 59075 RVA: 0x00365F74 File Offset: 0x00364174
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__1(Business x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600E6C4 RID: 59076 RVA: 0x00070350 File Offset: 0x0006E550
				public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700472E RID: 18222
				// (get) Token: 0x0600E6C5 RID: 59077 RVA: 0x00365FC4 File Offset: 0x003641C4
				// (set) Token: 0x0600E6C6 RID: 59078 RVA: 0x00070359 File Offset: 0x0006E559
				public unsafe string code
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04009A8F RID: 39567
				private static readonly System.IntPtr NativeFieldInfoPtr_code;

				// Token: 0x04009A90 RID: 39568
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04009A91 RID: 39569
				private static readonly System.IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0;

				// Token: 0x04009A92 RID: 39570
				private static readonly System.IntPtr NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0;
			}
		}

		// Token: 0x020008A9 RID: 2217
		public class Teleport : Console.ConsoleCommand
		{
			// Token: 0x0600C5F1 RID: 50673 RVA: 0x00307AC0 File Offset: 0x00305CC0
			// Note: this type is marked as 'beforefieldinit'.
			static Teleport()
			{
				Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Teleport");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr);
				Console.Teleport.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666468);
				Console.Teleport.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666469);
				Console.Teleport.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666470);
				Console.Teleport.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666471);
				Console.Teleport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666472);
			}

			// Token: 0x17003D6C RID: 15724
			// (get) Token: 0x0600C5F2 RID: 50674 RVA: 0x00307B50 File Offset: 0x00305D50
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105010, XrefRangeEnd = 105012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D6D RID: 15725
			// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x00307B94 File Offset: 0x00305D94
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105012, XrefRangeEnd = 105014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D6E RID: 15726
			// (get) Token: 0x0600C5F4 RID: 50676 RVA: 0x00307BD8 File Offset: 0x00305DD8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105014, XrefRangeEnd = 105016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5F5 RID: 50677 RVA: 0x00307C1C File Offset: 0x00305E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105016, XrefRangeEnd = 105044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5F6 RID: 50678 RVA: 0x00307C6C File Offset: 0x00305E6C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Teleport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Teleport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5F7 RID: 50679 RVA: 0x00060568 File Offset: 0x0005E768
			public Teleport(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008625 RID: 34341
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008626 RID: 34342
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008627 RID: 34343
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008628 RID: 34344
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008629 RID: 34345
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008AA RID: 2218
		public class PackageProduct : Console.ConsoleCommand
		{
			// Token: 0x0600C5F8 RID: 50680 RVA: 0x00307CA8 File Offset: 0x00305EA8
			// Note: this type is marked as 'beforefieldinit'.
			static PackageProduct()
			{
				Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "PackageProduct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr);
				Console.PackageProduct.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666473);
				Console.PackageProduct.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666474);
				Console.PackageProduct.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666475);
				Console.PackageProduct.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666476);
				Console.PackageProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666477);
			}

			// Token: 0x17003D6F RID: 15727
			// (get) Token: 0x0600C5F9 RID: 50681 RVA: 0x00307D38 File Offset: 0x00305F38
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105044, XrefRangeEnd = 105046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D70 RID: 15728
			// (get) Token: 0x0600C5FA RID: 50682 RVA: 0x00307D7C File Offset: 0x00305F7C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105046, XrefRangeEnd = 105048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D71 RID: 15729
			// (get) Token: 0x0600C5FB RID: 50683 RVA: 0x00307DC0 File Offset: 0x00305FC0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105048, XrefRangeEnd = 105050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C5FC RID: 50684 RVA: 0x00307E04 File Offset: 0x00306004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105050, XrefRangeEnd = 105115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5FD RID: 50685 RVA: 0x00307E54 File Offset: 0x00306054
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackageProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.PackageProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C5FE RID: 50686 RVA: 0x00060571 File Offset: 0x0005E771
			public PackageProduct(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400862A RID: 34346
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400862B RID: 34347
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400862C RID: 34348
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400862D RID: 34349
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400862E RID: 34350
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008AB RID: 2219
		public class SetStaminaReserve : Console.ConsoleCommand
		{
			// Token: 0x0600C5FF RID: 50687 RVA: 0x00307E90 File Offset: 0x00306090
			// Note: this type is marked as 'beforefieldinit'.
			static SetStaminaReserve()
			{
				Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetStaminaReserve");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666478);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666479);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666480);
				Console.SetStaminaReserve.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666481);
				Console.SetStaminaReserve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666482);
			}

			// Token: 0x17003D72 RID: 15730
			// (get) Token: 0x0600C600 RID: 50688 RVA: 0x00307F20 File Offset: 0x00306120
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105115, XrefRangeEnd = 105117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D73 RID: 15731
			// (get) Token: 0x0600C601 RID: 50689 RVA: 0x00307F64 File Offset: 0x00306164
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105117, XrefRangeEnd = 105119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D74 RID: 15732
			// (get) Token: 0x0600C602 RID: 50690 RVA: 0x00307FA8 File Offset: 0x003061A8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105119, XrefRangeEnd = 105121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C603 RID: 50691 RVA: 0x00307FEC File Offset: 0x003061EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105121, XrefRangeEnd = 105143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C604 RID: 50692 RVA: 0x0030803C File Offset: 0x0030623C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetStaminaReserve() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetStaminaReserve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C605 RID: 50693 RVA: 0x0006057A File Offset: 0x0005E77A
			public SetStaminaReserve(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400862F RID: 34351
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008630 RID: 34352
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008631 RID: 34353
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008632 RID: 34354
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008633 RID: 34355
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008AC RID: 2220
		public class RaisedWanted : Console.ConsoleCommand
		{
			// Token: 0x0600C606 RID: 50694 RVA: 0x00308078 File Offset: 0x00306278
			// Note: this type is marked as 'beforefieldinit'.
			static RaisedWanted()
			{
				Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "RaisedWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr);
				Console.RaisedWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666483);
				Console.RaisedWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666484);
				Console.RaisedWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666485);
				Console.RaisedWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666486);
				Console.RaisedWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666487);
			}

			// Token: 0x17003D75 RID: 15733
			// (get) Token: 0x0600C607 RID: 50695 RVA: 0x00308108 File Offset: 0x00306308
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105143, XrefRangeEnd = 105145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D76 RID: 15734
			// (get) Token: 0x0600C608 RID: 50696 RVA: 0x0030814C File Offset: 0x0030634C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105145, XrefRangeEnd = 105147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D77 RID: 15735
			// (get) Token: 0x0600C609 RID: 50697 RVA: 0x00308190 File Offset: 0x00306390
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105147, XrefRangeEnd = 105149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C60A RID: 50698 RVA: 0x003081D4 File Offset: 0x003063D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105149, XrefRangeEnd = 105186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C60B RID: 50699 RVA: 0x00308224 File Offset: 0x00306424
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaisedWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.RaisedWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C60C RID: 50700 RVA: 0x00060583 File Offset: 0x0005E783
			public RaisedWanted(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008634 RID: 34356
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008635 RID: 34357
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008636 RID: 34358
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008637 RID: 34359
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008638 RID: 34360
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008AD RID: 2221
		public class LowerWanted : Console.ConsoleCommand
		{
			// Token: 0x0600C60D RID: 50701 RVA: 0x00308260 File Offset: 0x00306460
			// Note: this type is marked as 'beforefieldinit'.
			static LowerWanted()
			{
				Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "LowerWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr);
				Console.LowerWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666488);
				Console.LowerWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666489);
				Console.LowerWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666490);
				Console.LowerWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666491);
				Console.LowerWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666492);
			}

			// Token: 0x17003D78 RID: 15736
			// (get) Token: 0x0600C60E RID: 50702 RVA: 0x003082F0 File Offset: 0x003064F0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105186, XrefRangeEnd = 105188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D79 RID: 15737
			// (get) Token: 0x0600C60F RID: 50703 RVA: 0x00308334 File Offset: 0x00306534
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105188, XrefRangeEnd = 105190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D7A RID: 15738
			// (get) Token: 0x0600C610 RID: 50704 RVA: 0x00308378 File Offset: 0x00306578
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105190, XrefRangeEnd = 105192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C611 RID: 50705 RVA: 0x003083BC File Offset: 0x003065BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105192, XrefRangeEnd = 105207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C612 RID: 50706 RVA: 0x0030840C File Offset: 0x0030660C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowerWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.LowerWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C613 RID: 50707 RVA: 0x0006058C File Offset: 0x0005E78C
			public LowerWanted(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008639 RID: 34361
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400863A RID: 34362
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400863B RID: 34363
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400863C RID: 34364
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400863D RID: 34365
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008AE RID: 2222
		public class ClearWanted : Console.ConsoleCommand
		{
			// Token: 0x0600C614 RID: 50708 RVA: 0x00308448 File Offset: 0x00306648
			// Note: this type is marked as 'beforefieldinit'.
			static ClearWanted()
			{
				Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr);
				Console.ClearWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666493);
				Console.ClearWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666494);
				Console.ClearWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666495);
				Console.ClearWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666496);
				Console.ClearWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666497);
			}

			// Token: 0x17003D7B RID: 15739
			// (get) Token: 0x0600C615 RID: 50709 RVA: 0x003084D8 File Offset: 0x003066D8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105207, XrefRangeEnd = 105209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D7C RID: 15740
			// (get) Token: 0x0600C616 RID: 50710 RVA: 0x0030851C File Offset: 0x0030671C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105209, XrefRangeEnd = 105211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D7D RID: 15741
			// (get) Token: 0x0600C617 RID: 50711 RVA: 0x00308560 File Offset: 0x00306760
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105211, XrefRangeEnd = 105213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C618 RID: 50712 RVA: 0x003085A4 File Offset: 0x003067A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105213, XrefRangeEnd = 105233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C619 RID: 50713 RVA: 0x003085F4 File Offset: 0x003067F4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C61A RID: 50714 RVA: 0x00060595 File Offset: 0x0005E795
			public ClearWanted(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400863E RID: 34366
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400863F RID: 34367
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008640 RID: 34368
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008641 RID: 34369
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008642 RID: 34370
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008AF RID: 2223
		public class SetHealth : Console.ConsoleCommand
		{
			// Token: 0x0600C61B RID: 50715 RVA: 0x00308630 File Offset: 0x00306830
			// Note: this type is marked as 'beforefieldinit'.
			static SetHealth()
			{
				Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetHealth");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr);
				Console.SetHealth.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666498);
				Console.SetHealth.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666499);
				Console.SetHealth.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666500);
				Console.SetHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666501);
				Console.SetHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666502);
			}

			// Token: 0x17003D7E RID: 15742
			// (get) Token: 0x0600C61C RID: 50716 RVA: 0x003086C0 File Offset: 0x003068C0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105233, XrefRangeEnd = 105235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D7F RID: 15743
			// (get) Token: 0x0600C61D RID: 50717 RVA: 0x00308704 File Offset: 0x00306904
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105235, XrefRangeEnd = 105237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D80 RID: 15744
			// (get) Token: 0x0600C61E RID: 50718 RVA: 0x00308748 File Offset: 0x00306948
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105237, XrefRangeEnd = 105239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C61F RID: 50719 RVA: 0x0030878C File Offset: 0x0030698C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105239, XrefRangeEnd = 105266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C620 RID: 50720 RVA: 0x003087DC File Offset: 0x003069DC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C621 RID: 50721 RVA: 0x0006059E File Offset: 0x0005E79E
			public SetHealth(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008643 RID: 34371
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008644 RID: 34372
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008645 RID: 34373
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008646 RID: 34374
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008647 RID: 34375
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B0 RID: 2224
		public class SetEnergy : Console.ConsoleCommand
		{
			// Token: 0x0600C622 RID: 50722 RVA: 0x00308818 File Offset: 0x00306A18
			// Note: this type is marked as 'beforefieldinit'.
			static SetEnergy()
			{
				Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetEnergy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr);
				Console.SetEnergy.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666503);
				Console.SetEnergy.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666504);
				Console.SetEnergy.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666505);
				Console.SetEnergy.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666506);
				Console.SetEnergy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666507);
			}

			// Token: 0x17003D81 RID: 15745
			// (get) Token: 0x0600C623 RID: 50723 RVA: 0x003088A8 File Offset: 0x00306AA8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105266, XrefRangeEnd = 105268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D82 RID: 15746
			// (get) Token: 0x0600C624 RID: 50724 RVA: 0x003088EC File Offset: 0x00306AEC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105268, XrefRangeEnd = 105270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D83 RID: 15747
			// (get) Token: 0x0600C625 RID: 50725 RVA: 0x00308930 File Offset: 0x00306B30
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105270, XrefRangeEnd = 105272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C626 RID: 50726 RVA: 0x00308974 File Offset: 0x00306B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105272, XrefRangeEnd = 105291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C627 RID: 50727 RVA: 0x003089C4 File Offset: 0x00306BC4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetEnergy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetEnergy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C628 RID: 50728 RVA: 0x000605A7 File Offset: 0x0005E7A7
			public SetEnergy(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008648 RID: 34376
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008649 RID: 34377
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400864A RID: 34378
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400864B RID: 34379
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400864C RID: 34380
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B1 RID: 2225
		public class FreeCamCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C629 RID: 50729 RVA: 0x00308A00 File Offset: 0x00306C00
			// Note: this type is marked as 'beforefieldinit'.
			static FreeCamCommand()
			{
				Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "FreeCamCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666508);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666509);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666510);
				Console.FreeCamCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666511);
				Console.FreeCamCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666512);
			}

			// Token: 0x17003D84 RID: 15748
			// (get) Token: 0x0600C62A RID: 50730 RVA: 0x00308A90 File Offset: 0x00306C90
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105291, XrefRangeEnd = 105293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D85 RID: 15749
			// (get) Token: 0x0600C62B RID: 50731 RVA: 0x00308AD4 File Offset: 0x00306CD4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105293, XrefRangeEnd = 105295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D86 RID: 15750
			// (get) Token: 0x0600C62C RID: 50732 RVA: 0x00308B18 File Offset: 0x00306D18
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105295, XrefRangeEnd = 105297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C62D RID: 50733 RVA: 0x00308B5C File Offset: 0x00306D5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105297, XrefRangeEnd = 105310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C62E RID: 50734 RVA: 0x00308BAC File Offset: 0x00306DAC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FreeCamCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.FreeCamCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C62F RID: 50735 RVA: 0x000605B0 File Offset: 0x0005E7B0
			public FreeCamCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400864D RID: 34381
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400864E RID: 34382
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400864F RID: 34383
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008650 RID: 34384
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008651 RID: 34385
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B2 RID: 2226
		public class Save : Console.ConsoleCommand
		{
			// Token: 0x0600C630 RID: 50736 RVA: 0x00308BE8 File Offset: 0x00306DE8
			// Note: this type is marked as 'beforefieldinit'.
			static Save()
			{
				Il2CppClassPointerStore<Console.Save>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Save");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Save>.NativeClassPtr);
				Console.Save.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666513);
				Console.Save.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666514);
				Console.Save.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666515);
				Console.Save.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666516);
				Console.Save.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666517);
			}

			// Token: 0x17003D87 RID: 15751
			// (get) Token: 0x0600C631 RID: 50737 RVA: 0x00308C78 File Offset: 0x00306E78
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105310, XrefRangeEnd = 105312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D88 RID: 15752
			// (get) Token: 0x0600C632 RID: 50738 RVA: 0x00308CBC File Offset: 0x00306EBC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105312, XrefRangeEnd = 105314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D89 RID: 15753
			// (get) Token: 0x0600C633 RID: 50739 RVA: 0x00308D00 File Offset: 0x00306F00
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105314, XrefRangeEnd = 105316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C634 RID: 50740 RVA: 0x00308D44 File Offset: 0x00306F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105316, XrefRangeEnd = 105331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C635 RID: 50741 RVA: 0x00308D94 File Offset: 0x00306F94
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Save() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Save>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Save.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C636 RID: 50742 RVA: 0x000605B9 File Offset: 0x0005E7B9
			public Save(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008652 RID: 34386
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008653 RID: 34387
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008654 RID: 34388
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008655 RID: 34389
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008656 RID: 34390
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B3 RID: 2227
		public class SetTimeScale : Console.ConsoleCommand
		{
			// Token: 0x0600C637 RID: 50743 RVA: 0x00308DD0 File Offset: 0x00306FD0
			// Note: this type is marked as 'beforefieldinit'.
			static SetTimeScale()
			{
				Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetTimeScale");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr);
				Console.SetTimeScale.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666518);
				Console.SetTimeScale.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666519);
				Console.SetTimeScale.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666520);
				Console.SetTimeScale.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666521);
				Console.SetTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666522);
			}

			// Token: 0x17003D8A RID: 15754
			// (get) Token: 0x0600C638 RID: 50744 RVA: 0x00308E60 File Offset: 0x00307060
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105331, XrefRangeEnd = 105333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D8B RID: 15755
			// (get) Token: 0x0600C639 RID: 50745 RVA: 0x00308EA4 File Offset: 0x003070A4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105333, XrefRangeEnd = 105335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D8C RID: 15756
			// (get) Token: 0x0600C63A RID: 50746 RVA: 0x00308EE8 File Offset: 0x003070E8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105335, XrefRangeEnd = 105337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C63B RID: 50747 RVA: 0x00308F2C File Offset: 0x0030712C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105337, XrefRangeEnd = 105358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C63C RID: 50748 RVA: 0x00308F7C File Offset: 0x0030717C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetTimeScale() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C63D RID: 50749 RVA: 0x000605C2 File Offset: 0x0005E7C2
			public SetTimeScale(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008657 RID: 34391
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008658 RID: 34392
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008659 RID: 34393
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400865A RID: 34394
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400865B RID: 34395
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B4 RID: 2228
		public class SetVariableValue : Console.ConsoleCommand
		{
			// Token: 0x0600C63E RID: 50750 RVA: 0x00308FB8 File Offset: 0x003071B8
			// Note: this type is marked as 'beforefieldinit'.
			static SetVariableValue()
			{
				Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetVariableValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr);
				Console.SetVariableValue.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666523);
				Console.SetVariableValue.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666524);
				Console.SetVariableValue.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666525);
				Console.SetVariableValue.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666526);
				Console.SetVariableValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666527);
			}

			// Token: 0x17003D8D RID: 15757
			// (get) Token: 0x0600C63F RID: 50751 RVA: 0x00309048 File Offset: 0x00307248
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105358, XrefRangeEnd = 105360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D8E RID: 15758
			// (get) Token: 0x0600C640 RID: 50752 RVA: 0x0030908C File Offset: 0x0030728C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105360, XrefRangeEnd = 105362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D8F RID: 15759
			// (get) Token: 0x0600C641 RID: 50753 RVA: 0x003090D0 File Offset: 0x003072D0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105362, XrefRangeEnd = 105364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C642 RID: 50754 RVA: 0x00309114 File Offset: 0x00307314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105364, XrefRangeEnd = 105386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C643 RID: 50755 RVA: 0x00309164 File Offset: 0x00307364
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetVariableValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetVariableValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C644 RID: 50756 RVA: 0x000605CB File Offset: 0x0005E7CB
			public SetVariableValue(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400865C RID: 34396
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400865D RID: 34397
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400865E RID: 34398
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400865F RID: 34399
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008660 RID: 34400
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B5 RID: 2229
		public class SetQuestState : Console.ConsoleCommand
		{
			// Token: 0x0600C645 RID: 50757 RVA: 0x003091A0 File Offset: 0x003073A0
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuestState()
			{
				Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuestState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr);
				Console.SetQuestState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666528);
				Console.SetQuestState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666529);
				Console.SetQuestState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666530);
				Console.SetQuestState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666531);
				Console.SetQuestState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666532);
			}

			// Token: 0x17003D90 RID: 15760
			// (get) Token: 0x0600C646 RID: 50758 RVA: 0x00309230 File Offset: 0x00307430
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105386, XrefRangeEnd = 105388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D91 RID: 15761
			// (get) Token: 0x0600C647 RID: 50759 RVA: 0x00309274 File Offset: 0x00307474
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105388, XrefRangeEnd = 105390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D92 RID: 15762
			// (get) Token: 0x0600C648 RID: 50760 RVA: 0x003092B8 File Offset: 0x003074B8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105390, XrefRangeEnd = 105392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C649 RID: 50761 RVA: 0x003092FC File Offset: 0x003074FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105392, XrefRangeEnd = 105426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C64A RID: 50762 RVA: 0x0030934C File Offset: 0x0030754C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuestState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuestState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C64B RID: 50763 RVA: 0x000605D4 File Offset: 0x0005E7D4
			public SetQuestState(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008661 RID: 34401
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008662 RID: 34402
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008663 RID: 34403
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008664 RID: 34404
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008665 RID: 34405
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B6 RID: 2230
		public class SetQuestEntryState : Console.ConsoleCommand
		{
			// Token: 0x0600C64C RID: 50764 RVA: 0x00309388 File Offset: 0x00307588
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuestEntryState()
			{
				Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuestEntryState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666533);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666534);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666535);
				Console.SetQuestEntryState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666536);
				Console.SetQuestEntryState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666537);
			}

			// Token: 0x17003D93 RID: 15763
			// (get) Token: 0x0600C64D RID: 50765 RVA: 0x00309418 File Offset: 0x00307618
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105426, XrefRangeEnd = 105428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D94 RID: 15764
			// (get) Token: 0x0600C64E RID: 50766 RVA: 0x0030945C File Offset: 0x0030765C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105428, XrefRangeEnd = 105430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D95 RID: 15765
			// (get) Token: 0x0600C64F RID: 50767 RVA: 0x003094A0 File Offset: 0x003076A0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105430, XrefRangeEnd = 105432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C650 RID: 50768 RVA: 0x003094E4 File Offset: 0x003076E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105432, XrefRangeEnd = 105471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C651 RID: 50769 RVA: 0x00309534 File Offset: 0x00307734
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuestEntryState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuestEntryState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C652 RID: 50770 RVA: 0x000605DD File Offset: 0x0005E7DD
			public SetQuestEntryState(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008666 RID: 34406
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008667 RID: 34407
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008668 RID: 34408
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008669 RID: 34409
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400866A RID: 34410
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B7 RID: 2231
		public class SetEmotion : Console.ConsoleCommand
		{
			// Token: 0x0600C653 RID: 50771 RVA: 0x00309570 File Offset: 0x00307770
			// Note: this type is marked as 'beforefieldinit'.
			static SetEmotion()
			{
				Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetEmotion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr);
				Console.SetEmotion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666538);
				Console.SetEmotion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666539);
				Console.SetEmotion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666540);
				Console.SetEmotion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666541);
				Console.SetEmotion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666542);
			}

			// Token: 0x17003D96 RID: 15766
			// (get) Token: 0x0600C654 RID: 50772 RVA: 0x00309600 File Offset: 0x00307800
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105471, XrefRangeEnd = 105473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D97 RID: 15767
			// (get) Token: 0x0600C655 RID: 50773 RVA: 0x00309644 File Offset: 0x00307844
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105473, XrefRangeEnd = 105475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D98 RID: 15768
			// (get) Token: 0x0600C656 RID: 50774 RVA: 0x00309688 File Offset: 0x00307888
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105475, XrefRangeEnd = 105477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C657 RID: 50775 RVA: 0x003096CC File Offset: 0x003078CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105477, XrefRangeEnd = 105508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C658 RID: 50776 RVA: 0x0030971C File Offset: 0x0030791C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetEmotion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetEmotion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C659 RID: 50777 RVA: 0x000605E6 File Offset: 0x0005E7E6
			public SetEmotion(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400866B RID: 34411
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400866C RID: 34412
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400866D RID: 34413
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400866E RID: 34414
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400866F RID: 34415
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B8 RID: 2232
		public class SetUnlocked : Console.ConsoleCommand
		{
			// Token: 0x0600C65A RID: 50778 RVA: 0x00309758 File Offset: 0x00307958
			// Note: this type is marked as 'beforefieldinit'.
			static SetUnlocked()
			{
				Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetUnlocked");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr);
				Console.SetUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666543);
				Console.SetUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666544);
				Console.SetUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666545);
				Console.SetUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666546);
				Console.SetUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666547);
			}

			// Token: 0x17003D99 RID: 15769
			// (get) Token: 0x0600C65B RID: 50779 RVA: 0x003097E8 File Offset: 0x003079E8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105508, XrefRangeEnd = 105510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D9A RID: 15770
			// (get) Token: 0x0600C65C RID: 50780 RVA: 0x0030982C File Offset: 0x00307A2C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105510, XrefRangeEnd = 105512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D9B RID: 15771
			// (get) Token: 0x0600C65D RID: 50781 RVA: 0x00309870 File Offset: 0x00307A70
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105512, XrefRangeEnd = 105514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C65E RID: 50782 RVA: 0x003098B4 File Offset: 0x00307AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105514, XrefRangeEnd = 105544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C65F RID: 50783 RVA: 0x00309904 File Offset: 0x00307B04
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetUnlocked() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C660 RID: 50784 RVA: 0x000605EF File Offset: 0x0005E7EF
			public SetUnlocked(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008670 RID: 34416
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008671 RID: 34417
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008672 RID: 34418
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008673 RID: 34419
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008674 RID: 34420
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B9 RID: 2233
		public class SetRelationship : Console.ConsoleCommand
		{
			// Token: 0x0600C661 RID: 50785 RVA: 0x00309940 File Offset: 0x00307B40
			// Note: this type is marked as 'beforefieldinit'.
			static SetRelationship()
			{
				Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetRelationship");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr);
				Console.SetRelationship.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666548);
				Console.SetRelationship.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666549);
				Console.SetRelationship.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666550);
				Console.SetRelationship.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666551);
				Console.SetRelationship.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666552);
			}

			// Token: 0x17003D9C RID: 15772
			// (get) Token: 0x0600C662 RID: 50786 RVA: 0x003099D0 File Offset: 0x00307BD0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105544, XrefRangeEnd = 105546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D9D RID: 15773
			// (get) Token: 0x0600C663 RID: 50787 RVA: 0x00309A14 File Offset: 0x00307C14
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105546, XrefRangeEnd = 105548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003D9E RID: 15774
			// (get) Token: 0x0600C664 RID: 50788 RVA: 0x00309A58 File Offset: 0x00307C58
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105548, XrefRangeEnd = 105550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C665 RID: 50789 RVA: 0x00309A9C File Offset: 0x00307C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105550, XrefRangeEnd = 105574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C666 RID: 50790 RVA: 0x00309AEC File Offset: 0x00307CEC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetRelationship() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetRelationship.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C667 RID: 50791 RVA: 0x000605F8 File Offset: 0x0005E7F8
			public SetRelationship(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008675 RID: 34421
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008676 RID: 34422
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008677 RID: 34423
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008678 RID: 34424
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008679 RID: 34425
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008BA RID: 2234
		public class AddEmployeeCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C668 RID: 50792 RVA: 0x00309B28 File Offset: 0x00307D28
			// Note: this type is marked as 'beforefieldinit'.
			static AddEmployeeCommand()
			{
				Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "AddEmployeeCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666553);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666554);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666555);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666556);
				Console.AddEmployeeCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666557);
			}

			// Token: 0x17003D9F RID: 15775
			// (get) Token: 0x0600C669 RID: 50793 RVA: 0x00309BB8 File Offset: 0x00307DB8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105574, XrefRangeEnd = 105576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DA0 RID: 15776
			// (get) Token: 0x0600C66A RID: 50794 RVA: 0x00309BFC File Offset: 0x00307DFC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105576, XrefRangeEnd = 105578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DA1 RID: 15777
			// (get) Token: 0x0600C66B RID: 50795 RVA: 0x00309C40 File Offset: 0x00307E40
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105578, XrefRangeEnd = 105580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C66C RID: 50796 RVA: 0x00309C84 File Offset: 0x00307E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105580, XrefRangeEnd = 105610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C66D RID: 50797 RVA: 0x00309CD4 File Offset: 0x00307ED4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddEmployeeCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C66E RID: 50798 RVA: 0x00060601 File Offset: 0x0005E801
			public AddEmployeeCommand(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400867A RID: 34426
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400867B RID: 34427
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400867C RID: 34428
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400867D RID: 34429
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400867E RID: 34430
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C89 RID: 3209
			[ObfuscatedName("ScheduleOne.Console+AddEmployeeCommand+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E6C7 RID: 59079 RVA: 0x00365FEC File Offset: 0x003641EC
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr);
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, 100666558);
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, 100666559);
				}

				// Token: 0x0600E6C8 RID: 59080 RVA: 0x00366054 File Offset: 0x00364254
				[CallerCount(2576)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr))
				{
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E6C9 RID: 59081 RVA: 0x00366090 File Offset: 0x00364290
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Property x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600E6CA RID: 59082 RVA: 0x00070378 File Offset: 0x0006E578
				public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700472F RID: 18223
				// (get) Token: 0x0600E6CB RID: 59083 RVA: 0x003660E0 File Offset: 0x003642E0
				// (set) Token: 0x0600E6CC RID: 59084 RVA: 0x00070381 File Offset: 0x0006E581
				public unsafe string code
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04009A93 RID: 39571
				private static readonly System.IntPtr NativeFieldInfoPtr_code;

				// Token: 0x04009A94 RID: 39572
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04009A95 RID: 39573
				private static readonly System.IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0;
			}
		}

		// Token: 0x020008BB RID: 2235
		public class SetDiscovered : Console.ConsoleCommand
		{
			// Token: 0x0600C66F RID: 50799 RVA: 0x00309D10 File Offset: 0x00307F10
			// Note: this type is marked as 'beforefieldinit'.
			static SetDiscovered()
			{
				Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetDiscovered");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr);
				Console.SetDiscovered.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666560);
				Console.SetDiscovered.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666561);
				Console.SetDiscovered.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666562);
				Console.SetDiscovered.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666563);
				Console.SetDiscovered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666564);
			}

			// Token: 0x17003DA2 RID: 15778
			// (get) Token: 0x0600C670 RID: 50800 RVA: 0x00309DA0 File Offset: 0x00307FA0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105610, XrefRangeEnd = 105612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DA3 RID: 15779
			// (get) Token: 0x0600C671 RID: 50801 RVA: 0x00309DE4 File Offset: 0x00307FE4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105612, XrefRangeEnd = 105614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DA4 RID: 15780
			// (get) Token: 0x0600C672 RID: 50802 RVA: 0x00309E28 File Offset: 0x00308028
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105614, XrefRangeEnd = 105616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C673 RID: 50803 RVA: 0x00309E6C File Offset: 0x0030806C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105616, XrefRangeEnd = 105660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C674 RID: 50804 RVA: 0x00309EBC File Offset: 0x003080BC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetDiscovered() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetDiscovered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C675 RID: 50805 RVA: 0x0006060A File Offset: 0x0005E80A
			public SetDiscovered(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400867F RID: 34431
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008680 RID: 34432
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008681 RID: 34433
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008682 RID: 34434
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008683 RID: 34435
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008BC RID: 2236
		public class GrowPlants : Console.ConsoleCommand
		{
			// Token: 0x0600C676 RID: 50806 RVA: 0x00309EF8 File Offset: 0x003080F8
			// Note: this type is marked as 'beforefieldinit'.
			static GrowPlants()
			{
				Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "GrowPlants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr);
				Console.GrowPlants.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666565);
				Console.GrowPlants.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666566);
				Console.GrowPlants.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666567);
				Console.GrowPlants.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666568);
				Console.GrowPlants.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666569);
			}

			// Token: 0x17003DA5 RID: 15781
			// (get) Token: 0x0600C677 RID: 50807 RVA: 0x00309F88 File Offset: 0x00308188
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105660, XrefRangeEnd = 105662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DA6 RID: 15782
			// (get) Token: 0x0600C678 RID: 50808 RVA: 0x00309FCC File Offset: 0x003081CC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105662, XrefRangeEnd = 105664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DA7 RID: 15783
			// (get) Token: 0x0600C679 RID: 50809 RVA: 0x0030A010 File Offset: 0x00308210
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105664, XrefRangeEnd = 105666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C67A RID: 50810 RVA: 0x0030A054 File Offset: 0x00308254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105666, XrefRangeEnd = 105674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C67B RID: 50811 RVA: 0x0030A0A4 File Offset: 0x003082A4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GrowPlants() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.GrowPlants.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C67C RID: 50812 RVA: 0x00060613 File Offset: 0x0005E813
			public GrowPlants(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008684 RID: 34436
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008685 RID: 34437
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008686 RID: 34438
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008687 RID: 34439
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008688 RID: 34440
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008BD RID: 2237
		public class SetLawIntensity : Console.ConsoleCommand
		{
			// Token: 0x0600C67D RID: 50813 RVA: 0x0030A0E0 File Offset: 0x003082E0
			// Note: this type is marked as 'beforefieldinit'.
			static SetLawIntensity()
			{
				Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetLawIntensity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666570);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666571);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666572);
				Console.SetLawIntensity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666573);
				Console.SetLawIntensity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666574);
			}

			// Token: 0x17003DA8 RID: 15784
			// (get) Token: 0x0600C67E RID: 50814 RVA: 0x0030A170 File Offset: 0x00308370
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105674, XrefRangeEnd = 105676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DA9 RID: 15785
			// (get) Token: 0x0600C67F RID: 50815 RVA: 0x0030A1B4 File Offset: 0x003083B4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105676, XrefRangeEnd = 105678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DAA RID: 15786
			// (get) Token: 0x0600C680 RID: 50816 RVA: 0x0030A1F8 File Offset: 0x003083F8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105678, XrefRangeEnd = 105680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C681 RID: 50817 RVA: 0x0030A23C File Offset: 0x0030843C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105680, XrefRangeEnd = 105699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C682 RID: 50818 RVA: 0x0030A28C File Offset: 0x0030848C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetLawIntensity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetLawIntensity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C683 RID: 50819 RVA: 0x0006061C File Offset: 0x0005E81C
			public SetLawIntensity(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008689 RID: 34441
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400868A RID: 34442
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400868B RID: 34443
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400868C RID: 34444
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400868D RID: 34445
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008BE RID: 2238
		public class SetQuality : Console.ConsoleCommand
		{
			// Token: 0x0600C684 RID: 50820 RVA: 0x0030A2C8 File Offset: 0x003084C8
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuality()
			{
				Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuality");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr);
				Console.SetQuality.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666575);
				Console.SetQuality.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666576);
				Console.SetQuality.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666577);
				Console.SetQuality.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666578);
				Console.SetQuality.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666579);
			}

			// Token: 0x17003DAB RID: 15787
			// (get) Token: 0x0600C685 RID: 50821 RVA: 0x0030A358 File Offset: 0x00308558
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105699, XrefRangeEnd = 105701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DAC RID: 15788
			// (get) Token: 0x0600C686 RID: 50822 RVA: 0x0030A39C File Offset: 0x0030859C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105701, XrefRangeEnd = 105703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DAD RID: 15789
			// (get) Token: 0x0600C687 RID: 50823 RVA: 0x0030A3E0 File Offset: 0x003085E0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105703, XrefRangeEnd = 105705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C688 RID: 50824 RVA: 0x0030A424 File Offset: 0x00308624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105705, XrefRangeEnd = 105724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C689 RID: 50825 RVA: 0x0030A474 File Offset: 0x00308674
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuality() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuality.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C68A RID: 50826 RVA: 0x00060625 File Offset: 0x0005E825
			public SetQuality(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400868E RID: 34446
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400868F RID: 34447
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008690 RID: 34448
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008691 RID: 34449
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008692 RID: 34450
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008BF RID: 2239
		public class Bind : Console.ConsoleCommand
		{
			// Token: 0x0600C68B RID: 50827 RVA: 0x0030A4B0 File Offset: 0x003086B0
			// Note: this type is marked as 'beforefieldinit'.
			static Bind()
			{
				Il2CppClassPointerStore<Console.Bind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Bind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr);
				Console.Bind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666580);
				Console.Bind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666581);
				Console.Bind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666582);
				Console.Bind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666583);
				Console.Bind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666584);
			}

			// Token: 0x17003DAE RID: 15790
			// (get) Token: 0x0600C68C RID: 50828 RVA: 0x0030A540 File Offset: 0x00308740
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105724, XrefRangeEnd = 105726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DAF RID: 15791
			// (get) Token: 0x0600C68D RID: 50829 RVA: 0x0030A584 File Offset: 0x00308784
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105726, XrefRangeEnd = 105728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DB0 RID: 15792
			// (get) Token: 0x0600C68E RID: 50830 RVA: 0x0030A5C8 File Offset: 0x003087C8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105728, XrefRangeEnd = 105730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C68F RID: 50831 RVA: 0x0030A60C File Offset: 0x0030880C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105730, XrefRangeEnd = 105747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C690 RID: 50832 RVA: 0x0030A65C File Offset: 0x0030885C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Bind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Bind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C691 RID: 50833 RVA: 0x0006062E File Offset: 0x0005E82E
			public Bind(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008693 RID: 34451
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008694 RID: 34452
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008695 RID: 34453
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008696 RID: 34454
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008697 RID: 34455
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008C0 RID: 2240
		public class Unbind : Console.ConsoleCommand
		{
			// Token: 0x0600C692 RID: 50834 RVA: 0x0030A698 File Offset: 0x00308898
			// Note: this type is marked as 'beforefieldinit'.
			static Unbind()
			{
				Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Unbind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr);
				Console.Unbind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666585);
				Console.Unbind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666586);
				Console.Unbind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666587);
				Console.Unbind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666588);
				Console.Unbind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666589);
			}

			// Token: 0x17003DB1 RID: 15793
			// (get) Token: 0x0600C693 RID: 50835 RVA: 0x0030A728 File Offset: 0x00308928
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105747, XrefRangeEnd = 105749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DB2 RID: 15794
			// (get) Token: 0x0600C694 RID: 50836 RVA: 0x0030A76C File Offset: 0x0030896C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105749, XrefRangeEnd = 105751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DB3 RID: 15795
			// (get) Token: 0x0600C695 RID: 50837 RVA: 0x0030A7B0 File Offset: 0x003089B0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105751, XrefRangeEnd = 105753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C696 RID: 50838 RVA: 0x0030A7F4 File Offset: 0x003089F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105753, XrefRangeEnd = 105768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C697 RID: 50839 RVA: 0x0030A844 File Offset: 0x00308A44
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Unbind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Unbind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C698 RID: 50840 RVA: 0x00060637 File Offset: 0x0005E837
			public Unbind(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008698 RID: 34456
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008699 RID: 34457
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400869A RID: 34458
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400869B RID: 34459
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400869C RID: 34460
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008C1 RID: 2241
		public class ClearBinds : Console.ConsoleCommand
		{
			// Token: 0x0600C699 RID: 50841 RVA: 0x0030A880 File Offset: 0x00308A80
			// Note: this type is marked as 'beforefieldinit'.
			static ClearBinds()
			{
				Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearBinds");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr);
				Console.ClearBinds.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666590);
				Console.ClearBinds.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666591);
				Console.ClearBinds.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666592);
				Console.ClearBinds.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666593);
				Console.ClearBinds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666594);
			}

			// Token: 0x17003DB4 RID: 15796
			// (get) Token: 0x0600C69A RID: 50842 RVA: 0x0030A910 File Offset: 0x00308B10
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105768, XrefRangeEnd = 105770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DB5 RID: 15797
			// (get) Token: 0x0600C69B RID: 50843 RVA: 0x0030A954 File Offset: 0x00308B54
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105770, XrefRangeEnd = 105772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DB6 RID: 15798
			// (get) Token: 0x0600C69C RID: 50844 RVA: 0x0030A998 File Offset: 0x00308B98
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105772, XrefRangeEnd = 105774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C69D RID: 50845 RVA: 0x0030A9DC File Offset: 0x00308BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105774, XrefRangeEnd = 105791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C69E RID: 50846 RVA: 0x0030AA2C File Offset: 0x00308C2C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearBinds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearBinds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C69F RID: 50847 RVA: 0x00060640 File Offset: 0x0005E840
			public ClearBinds(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400869D RID: 34461
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400869E RID: 34462
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400869F RID: 34463
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086A0 RID: 34464
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086A1 RID: 34465
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008C2 RID: 2242
		public class HideUI : Console.ConsoleCommand
		{
			// Token: 0x0600C6A0 RID: 50848 RVA: 0x0030AA68 File Offset: 0x00308C68
			// Note: this type is marked as 'beforefieldinit'.
			static HideUI()
			{
				Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "HideUI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr);
				Console.HideUI.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666595);
				Console.HideUI.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666596);
				Console.HideUI.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666597);
				Console.HideUI.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666598);
				Console.HideUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666599);
			}

			// Token: 0x17003DB7 RID: 15799
			// (get) Token: 0x0600C6A1 RID: 50849 RVA: 0x0030AAF8 File Offset: 0x00308CF8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105791, XrefRangeEnd = 105793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DB8 RID: 15800
			// (get) Token: 0x0600C6A2 RID: 50850 RVA: 0x0030AB3C File Offset: 0x00308D3C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105793, XrefRangeEnd = 105795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DB9 RID: 15801
			// (get) Token: 0x0600C6A3 RID: 50851 RVA: 0x0030AB80 File Offset: 0x00308D80
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105795, XrefRangeEnd = 105797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6A4 RID: 50852 RVA: 0x0030ABC4 File Offset: 0x00308DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105797, XrefRangeEnd = 105803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6A5 RID: 50853 RVA: 0x0030AC14 File Offset: 0x00308E14
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HideUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.HideUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6A6 RID: 50854 RVA: 0x00060649 File Offset: 0x0005E849
			public HideUI(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086A2 RID: 34466
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086A3 RID: 34467
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086A4 RID: 34468
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086A5 RID: 34469
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086A6 RID: 34470
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008C3 RID: 2243
		public class GiveXP : Console.ConsoleCommand
		{
			// Token: 0x0600C6A7 RID: 50855 RVA: 0x0030AC50 File Offset: 0x00308E50
			// Note: this type is marked as 'beforefieldinit'.
			static GiveXP()
			{
				Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "GiveXP");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr);
				Console.GiveXP.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666600);
				Console.GiveXP.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666601);
				Console.GiveXP.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666602);
				Console.GiveXP.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666603);
				Console.GiveXP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666604);
			}

			// Token: 0x17003DBA RID: 15802
			// (get) Token: 0x0600C6A8 RID: 50856 RVA: 0x0030ACE0 File Offset: 0x00308EE0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105803, XrefRangeEnd = 105805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DBB RID: 15803
			// (get) Token: 0x0600C6A9 RID: 50857 RVA: 0x0030AD24 File Offset: 0x00308F24
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105805, XrefRangeEnd = 105807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DBC RID: 15804
			// (get) Token: 0x0600C6AA RID: 50858 RVA: 0x0030AD68 File Offset: 0x00308F68
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105807, XrefRangeEnd = 105809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6AB RID: 50859 RVA: 0x0030ADAC File Offset: 0x00308FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105809, XrefRangeEnd = 105830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6AC RID: 50860 RVA: 0x0030ADFC File Offset: 0x00308FFC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GiveXP() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.GiveXP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6AD RID: 50861 RVA: 0x00060652 File Offset: 0x0005E852
			public GiveXP(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086A7 RID: 34471
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086A8 RID: 34472
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086A9 RID: 34473
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086AA RID: 34474
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086AB RID: 34475
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008C4 RID: 2244
		public class Disable : Console.ConsoleCommand
		{
			// Token: 0x0600C6AE RID: 50862 RVA: 0x0030AE38 File Offset: 0x00309038
			// Note: this type is marked as 'beforefieldinit'.
			static Disable()
			{
				Il2CppClassPointerStore<Console.Disable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Disable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr);
				Console.Disable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666605);
				Console.Disable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666606);
				Console.Disable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666607);
				Console.Disable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666608);
				Console.Disable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666609);
			}

			// Token: 0x17003DBD RID: 15805
			// (get) Token: 0x0600C6AF RID: 50863 RVA: 0x0030AEC8 File Offset: 0x003090C8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105833, XrefRangeEnd = 105835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DBE RID: 15806
			// (get) Token: 0x0600C6B0 RID: 50864 RVA: 0x0030AF0C File Offset: 0x0030910C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105835, XrefRangeEnd = 105837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DBF RID: 15807
			// (get) Token: 0x0600C6B1 RID: 50865 RVA: 0x0030AF50 File Offset: 0x00309150
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105837, XrefRangeEnd = 105839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6B2 RID: 50866 RVA: 0x0030AF94 File Offset: 0x00309194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105839, XrefRangeEnd = 105881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6B3 RID: 50867 RVA: 0x0030AFE4 File Offset: 0x003091E4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Disable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6B4 RID: 50868 RVA: 0x0006065B File Offset: 0x0005E85B
			public Disable(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086AC RID: 34476
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086AD RID: 34477
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086AE RID: 34478
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086AF RID: 34479
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086B0 RID: 34480
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C8A RID: 3210
			[ObfuscatedName("ScheduleOne.Console+Disable+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E6CD RID: 59085 RVA: 0x00366108 File Offset: 0x00364308
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr);
					Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, 100666610);
					Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, 100666611);
				}

				// Token: 0x0600E6CE RID: 59086 RVA: 0x00366170 File Offset: 0x00364370
				[CallerCount(2576)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr))
				{
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E6CF RID: 59087 RVA: 0x003661AC File Offset: 0x003643AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105830, XrefRangeEnd = 105833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Console.LabelledGameObject x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600E6D0 RID: 59088 RVA: 0x000703A0 File Offset: 0x0006E5A0
				public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004730 RID: 18224
				// (get) Token: 0x0600E6D1 RID: 59089 RVA: 0x003661FC File Offset: 0x003643FC
				// (set) Token: 0x0600E6D2 RID: 59090 RVA: 0x000703A9 File Offset: 0x0006E5A9
				public unsafe string code
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04009A96 RID: 39574
				private static readonly System.IntPtr NativeFieldInfoPtr_code;

				// Token: 0x04009A97 RID: 39575
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04009A98 RID: 39576
				private static readonly System.IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0;
			}
		}

		// Token: 0x020008C5 RID: 2245
		public class Enable : Console.ConsoleCommand
		{
			// Token: 0x0600C6B5 RID: 50869 RVA: 0x0030B020 File Offset: 0x00309220
			// Note: this type is marked as 'beforefieldinit'.
			static Enable()
			{
				Il2CppClassPointerStore<Console.Enable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Enable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr);
				Console.Enable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666612);
				Console.Enable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666613);
				Console.Enable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666614);
				Console.Enable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666615);
				Console.Enable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666616);
			}

			// Token: 0x17003DC0 RID: 15808
			// (get) Token: 0x0600C6B6 RID: 50870 RVA: 0x0030B0B0 File Offset: 0x003092B0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105881, XrefRangeEnd = 105883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DC1 RID: 15809
			// (get) Token: 0x0600C6B7 RID: 50871 RVA: 0x0030B0F4 File Offset: 0x003092F4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105883, XrefRangeEnd = 105885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DC2 RID: 15810
			// (get) Token: 0x0600C6B8 RID: 50872 RVA: 0x0030B138 File Offset: 0x00309338
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105885, XrefRangeEnd = 105887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6B9 RID: 50873 RVA: 0x0030B17C File Offset: 0x0030937C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105887, XrefRangeEnd = 105929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6BA RID: 50874 RVA: 0x0030B1CC File Offset: 0x003093CC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6BB RID: 50875 RVA: 0x00060664 File Offset: 0x0005E864
			public Enable(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086B1 RID: 34481
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086B2 RID: 34482
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086B3 RID: 34483
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086B4 RID: 34484
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086B5 RID: 34485
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C8B RID: 3211
			[ObfuscatedName("ScheduleOne.Console+Enable+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E6D3 RID: 59091 RVA: 0x00366224 File Offset: 0x00364424
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr);
					Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, 100666617);
					Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, 100666618);
				}

				// Token: 0x0600E6D4 RID: 59092 RVA: 0x0036628C File Offset: 0x0036448C
				[CallerCount(2576)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr))
				{
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E6D5 RID: 59093 RVA: 0x003662C8 File Offset: 0x003644C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Console.LabelledGameObject x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600E6D6 RID: 59094 RVA: 0x000703C8 File Offset: 0x0006E5C8
				public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004731 RID: 18225
				// (get) Token: 0x0600E6D7 RID: 59095 RVA: 0x00366318 File Offset: 0x00364518
				// (set) Token: 0x0600E6D8 RID: 59096 RVA: 0x000703D1 File Offset: 0x0006E5D1
				public unsafe string code
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04009A99 RID: 39577
				private static readonly System.IntPtr NativeFieldInfoPtr_code;

				// Token: 0x04009A9A RID: 39578
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04009A9B RID: 39579
				private static readonly System.IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0;
			}
		}

		// Token: 0x020008C6 RID: 2246
		public class EndTutorial : Console.ConsoleCommand
		{
			// Token: 0x0600C6BC RID: 50876 RVA: 0x0030B208 File Offset: 0x00309408
			// Note: this type is marked as 'beforefieldinit'.
			static EndTutorial()
			{
				Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "EndTutorial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr);
				Console.EndTutorial.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666619);
				Console.EndTutorial.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666620);
				Console.EndTutorial.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666621);
				Console.EndTutorial.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666622);
				Console.EndTutorial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666623);
			}

			// Token: 0x17003DC3 RID: 15811
			// (get) Token: 0x0600C6BD RID: 50877 RVA: 0x0030B298 File Offset: 0x00309498
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105929, XrefRangeEnd = 105931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DC4 RID: 15812
			// (get) Token: 0x0600C6BE RID: 50878 RVA: 0x0030B2DC File Offset: 0x003094DC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105931, XrefRangeEnd = 105933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DC5 RID: 15813
			// (get) Token: 0x0600C6BF RID: 50879 RVA: 0x0030B320 File Offset: 0x00309520
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105933, XrefRangeEnd = 105935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6C0 RID: 50880 RVA: 0x0030B364 File Offset: 0x00309564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105935, XrefRangeEnd = 105941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6C1 RID: 50881 RVA: 0x0030B3B4 File Offset: 0x003095B4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EndTutorial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.EndTutorial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6C2 RID: 50882 RVA: 0x0006066D File Offset: 0x0005E86D
			public EndTutorial(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086B6 RID: 34486
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086B7 RID: 34487
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086B8 RID: 34488
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086B9 RID: 34489
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086BA RID: 34490
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008C7 RID: 2247
		public class DisableNPCAsset : Console.ConsoleCommand
		{
			// Token: 0x0600C6C3 RID: 50883 RVA: 0x0030B3F0 File Offset: 0x003095F0
			// Note: this type is marked as 'beforefieldinit'.
			static DisableNPCAsset()
			{
				Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisableNPCAsset");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666624);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666625);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666626);
				Console.DisableNPCAsset.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666627);
				Console.DisableNPCAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666628);
			}

			// Token: 0x17003DC6 RID: 15814
			// (get) Token: 0x0600C6C4 RID: 50884 RVA: 0x0030B480 File Offset: 0x00309680
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105941, XrefRangeEnd = 105943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DC7 RID: 15815
			// (get) Token: 0x0600C6C5 RID: 50885 RVA: 0x0030B4C4 File Offset: 0x003096C4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105943, XrefRangeEnd = 105945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DC8 RID: 15816
			// (get) Token: 0x0600C6C6 RID: 50886 RVA: 0x0030B508 File Offset: 0x00309708
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105945, XrefRangeEnd = 105947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6C7 RID: 50887 RVA: 0x0030B54C File Offset: 0x0030974C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105947, XrefRangeEnd = 105991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6C8 RID: 50888 RVA: 0x0030B59C File Offset: 0x0030979C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisableNPCAsset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisableNPCAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6C9 RID: 50889 RVA: 0x00060676 File Offset: 0x0005E876
			public DisableNPCAsset(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086BB RID: 34491
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086BC RID: 34492
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086BD RID: 34493
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086BE RID: 34494
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086BF RID: 34495
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008C8 RID: 2248
		public class ShowFPS : Console.ConsoleCommand
		{
			// Token: 0x0600C6CA RID: 50890 RVA: 0x0030B5D8 File Offset: 0x003097D8
			// Note: this type is marked as 'beforefieldinit'.
			static ShowFPS()
			{
				Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ShowFPS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr);
				Console.ShowFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666629);
				Console.ShowFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666630);
				Console.ShowFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666631);
				Console.ShowFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666632);
				Console.ShowFPS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666633);
			}

			// Token: 0x17003DC9 RID: 15817
			// (get) Token: 0x0600C6CB RID: 50891 RVA: 0x0030B668 File Offset: 0x00309868
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105991, XrefRangeEnd = 105993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DCA RID: 15818
			// (get) Token: 0x0600C6CC RID: 50892 RVA: 0x0030B6AC File Offset: 0x003098AC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105993, XrefRangeEnd = 105995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DCB RID: 15819
			// (get) Token: 0x0600C6CD RID: 50893 RVA: 0x0030B6F0 File Offset: 0x003098F0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105995, XrefRangeEnd = 105997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6CE RID: 50894 RVA: 0x0030B734 File Offset: 0x00309934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105997, XrefRangeEnd = 106004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6CF RID: 50895 RVA: 0x0030B784 File Offset: 0x00309984
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShowFPS() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ShowFPS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6D0 RID: 50896 RVA: 0x0006067F File Offset: 0x0005E87F
			public ShowFPS(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086C0 RID: 34496
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086C1 RID: 34497
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086C2 RID: 34498
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086C3 RID: 34499
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086C4 RID: 34500
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008C9 RID: 2249
		public class HideFPS : Console.ConsoleCommand
		{
			// Token: 0x0600C6D1 RID: 50897 RVA: 0x0030B7C0 File Offset: 0x003099C0
			// Note: this type is marked as 'beforefieldinit'.
			static HideFPS()
			{
				Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "HideFPS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr);
				Console.HideFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666634);
				Console.HideFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666635);
				Console.HideFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666636);
				Console.HideFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666637);
				Console.HideFPS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666638);
			}

			// Token: 0x17003DCC RID: 15820
			// (get) Token: 0x0600C6D2 RID: 50898 RVA: 0x0030B850 File Offset: 0x00309A50
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106004, XrefRangeEnd = 106006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DCD RID: 15821
			// (get) Token: 0x0600C6D3 RID: 50899 RVA: 0x0030B894 File Offset: 0x00309A94
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106006, XrefRangeEnd = 106008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DCE RID: 15822
			// (get) Token: 0x0600C6D4 RID: 50900 RVA: 0x0030B8D8 File Offset: 0x00309AD8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106008, XrefRangeEnd = 106010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6D5 RID: 50901 RVA: 0x0030B91C File Offset: 0x00309B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106010, XrefRangeEnd = 106017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6D6 RID: 50902 RVA: 0x0030B96C File Offset: 0x00309B6C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HideFPS() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.HideFPS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6D7 RID: 50903 RVA: 0x00060688 File Offset: 0x0005E888
			public HideFPS(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086C5 RID: 34501
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086C6 RID: 34502
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086C7 RID: 34503
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086C8 RID: 34504
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086C9 RID: 34505
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008CA RID: 2250
		public class ClearTrash : Console.ConsoleCommand
		{
			// Token: 0x0600C6D8 RID: 50904 RVA: 0x0030B9A8 File Offset: 0x00309BA8
			// Note: this type is marked as 'beforefieldinit'.
			static ClearTrash()
			{
				Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearTrash");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr);
				Console.ClearTrash.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666639);
				Console.ClearTrash.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666640);
				Console.ClearTrash.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666641);
				Console.ClearTrash.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666642);
				Console.ClearTrash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666643);
			}

			// Token: 0x17003DCF RID: 15823
			// (get) Token: 0x0600C6D9 RID: 50905 RVA: 0x0030BA38 File Offset: 0x00309C38
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106017, XrefRangeEnd = 106019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DD0 RID: 15824
			// (get) Token: 0x0600C6DA RID: 50906 RVA: 0x0030BA7C File Offset: 0x00309C7C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106019, XrefRangeEnd = 106021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DD1 RID: 15825
			// (get) Token: 0x0600C6DB RID: 50907 RVA: 0x0030BAC0 File Offset: 0x00309CC0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106021, XrefRangeEnd = 106023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6DC RID: 50908 RVA: 0x0030BB04 File Offset: 0x00309D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106023, XrefRangeEnd = 106029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6DD RID: 50909 RVA: 0x0030BB54 File Offset: 0x00309D54
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearTrash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearTrash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6DE RID: 50910 RVA: 0x00060691 File Offset: 0x0005E891
			public ClearTrash(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086CA RID: 34506
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086CB RID: 34507
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086CC RID: 34508
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086CD RID: 34509
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086CE RID: 34510
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008CB RID: 2251
		public class PlayCutscene : Console.ConsoleCommand
		{
			// Token: 0x0600C6DF RID: 50911 RVA: 0x0030BB90 File Offset: 0x00309D90
			// Note: this type is marked as 'beforefieldinit'.
			static PlayCutscene()
			{
				Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "PlayCutscene");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr);
				Console.PlayCutscene.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100666644);
				Console.PlayCutscene.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100666645);
				Console.PlayCutscene.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100666646);
				Console.PlayCutscene.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100666647);
				Console.PlayCutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100666648);
			}

			// Token: 0x17003DD2 RID: 15826
			// (get) Token: 0x0600C6E0 RID: 50912 RVA: 0x0030BC20 File Offset: 0x00309E20
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106029, XrefRangeEnd = 106031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PlayCutscene.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DD3 RID: 15827
			// (get) Token: 0x0600C6E1 RID: 50913 RVA: 0x0030BC64 File Offset: 0x00309E64
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106031, XrefRangeEnd = 106033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PlayCutscene.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003DD4 RID: 15828
			// (get) Token: 0x0600C6E2 RID: 50914 RVA: 0x0030BCA8 File Offset: 0x00309EA8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106033, XrefRangeEnd = 106035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PlayCutscene.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600C6E3 RID: 50915 RVA: 0x0030BCEC File Offset: 0x00309EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106035, XrefRangeEnd = 106047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PlayCutscene.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6E4 RID: 50916 RVA: 0x0030BD3C File Offset: 0x00309F3C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayCutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.PlayCutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6E5 RID: 50917 RVA: 0x0006069A File Offset: 0x0005E89A
			public PlayCutscene(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040086CF RID: 34511
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040086D0 RID: 34512
			private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040086D1 RID: 34513
			private static readonly System.IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040086D2 RID: 34514
			private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040086D3 RID: 34515
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008CC RID: 2252
		[System.Serializable]
		public class LabelledGameObject : Il2CppSystem.Object
		{
			// Token: 0x0600C6E6 RID: 50918 RVA: 0x0030BD78 File Offset: 0x00309F78
			// Note: this type is marked as 'beforefieldinit'.
			static LabelledGameObject()
			{
				Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "LabelledGameObject");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr);
				Console.LabelledGameObject.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, "Label");
				Console.LabelledGameObject.NativeFieldInfoPtr_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, "GameObject");
				Console.LabelledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, 100666649);
			}

			// Token: 0x0600C6E7 RID: 50919 RVA: 0x0030BDE0 File Offset: 0x00309FE0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LabelledGameObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.LabelledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6E8 RID: 50920 RVA: 0x000606A3 File Offset: 0x0005E8A3
			public LabelledGameObject(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DD5 RID: 15829
			// (get) Token: 0x0600C6E9 RID: 50921 RVA: 0x0030BE1C File Offset: 0x0030A01C
			// (set) Token: 0x0600C6EA RID: 50922 RVA: 0x000606AC File Offset: 0x0005E8AC
			public unsafe string Label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DD6 RID: 15830
			// (get) Token: 0x0600C6EB RID: 50923 RVA: 0x0030BE44 File Offset: 0x0030A044
			// (set) Token: 0x0600C6EC RID: 50924 RVA: 0x000606CB File Offset: 0x0005E8CB
			public unsafe GameObject GameObject
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_GameObject);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086D4 RID: 34516
			private static readonly System.IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x040086D5 RID: 34517
			private static readonly System.IntPtr NativeFieldInfoPtr_GameObject;

			// Token: 0x040086D6 RID: 34518
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
